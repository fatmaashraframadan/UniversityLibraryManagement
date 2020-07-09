using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityLibraryManagement
{
    public partial class Admin : Form
    {
        string cn="";
        SqlCommand comma = new SqlCommand();

        public Admin(string c)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cn = c;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter.Fill(this.library_Management_SystemDataSet.ADMIN);
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.library_Management_SystemDataSet.STUDENT);
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.library_Management_SystemDataSet.CATEGORY);
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.PUBLISHER' table. You can move, or remove it, as needed.
            this.pUBLISHERTableAdapter.Fill(this.library_Management_SystemDataSet.PUBLISHER);
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter.Fill(this.library_Management_SystemDataSet.BOOK);
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.bOOKTableAdapter.Fill(this.library_Management_SystemDataSet.BOOK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                //Number of books with this isbn.
                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(ISBN) AS NumberOfBooks FROM [dbo].[BOOK] where ISBN = " + textBox1.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                //check if this book's publisher exists.
                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(PUB_ID) AS NumberOfPublisher FROM [dbo].[PUBLISHER] where PUB_ID = " + textBox2.Text + "");
                int tmp2 = (Int32)comma.ExecuteScalar();

                //check if bok's category is exist.
                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(CAT_ID) AS NumberOfCategory FROM [dbo].[CATEGORY] where CAT_ID = " + textBox3.Text + "");
                int tmp3 = (Int32)comma.ExecuteScalar();

                if (tmp == 0 && tmp2 > 0 && tmp3 > 0)
                {
                    sqlCommand.CommandText = "INSERT INTO BOOK VALUES(" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + ",'" + textBox4.Text + "','" + textBox5.Text + "'," + textBox6.Text + "," + textBox7.Text + "," + textBox8.Text + "," + textBox9.Text + ",'" + textBox10.Text + "')";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Insertion Was Succsesfully Completed");
                }
                else
                {
                    if (tmp != 0) MessageBox.Show("\tBOOK ISBN Already Excist\t");
                    else if (tmp2 == 0) MessageBox.Show("\tPublisher is not found\t");
                    else if (tmp3 == 0) MessageBox.Show("\tCategory is not found\t");
                }

                sqlConenction.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                //update all book data except its isbn.
                //check if this book is exist.
                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(ISBN) AS NumberOfBooks FROM [dbo].[BOOK] where ISBN = " + textBox1.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                //check if book publisher name is exist .
                comma.CommandText = ("SELECT COUNT(PUB_ID) AS NumberOfPublisher FROM [dbo].[PUBLISHER] where PUB_ID = " + textBox2.Text + "");
                int tmp2 = (Int32)comma.ExecuteScalar();

                //check if book category is exist .
                comma.CommandText = ("SELECT COUNT(CAT_ID) AS NumberOfStudent FROM [dbo].[CATEGORY] where CAT_ID = " + textBox3.Text + "");
                int tmp3 = (Int32)comma.ExecuteScalar();

                if (tmp == 1 && tmp2 > 0 && tmp3 > 0)
                {
                    sqlCommand.CommandText = "UPDATE BOOK SET PUB_ID = " + textBox2.Text + " , CAT_ID = " + textBox3.Text + ", TITLE = '" + textBox4.Text + "', LANGUAGE = '" + textBox5.Text + "', NUM_OF_PAGES = " + textBox6.Text + ", YEAR = " + textBox7.Text + ", PRICE = " + textBox8.Text + ", AVAILABLE = " + textBox9.Text + ", AUTHOR = '" + textBox10.Text + "' where ISBN = " + textBox1.Text + "";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Was Succsesfully Completed");
                }
                else
                {
                    if (tmp == 0) MessageBox.Show("\tISBN is not found\t");
                    else if (tmp2 == 0) MessageBox.Show("\tPublisher is not found\t");
                    else if (tmp3 == 0) MessageBox.Show("\tCategory is not found\t");
                }

                sqlConenction.Close();
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(ISBN) AS NumberOfStudent FROM [dbo].[BOOK] where ISBN = " + textBox1.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 1)
                {
                    sqlCommand.CommandText = "DELETE FROM BOOK where ISBN = " + textBox1.Text + "";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Delete Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("\tISBN is not found\t");
                }

                sqlConenction.Close();
            }            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox20.Text == "" || textBox19.Text == "" || textBox18.Text== "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(PUB_ID) AS NumberOfStudent FROM [dbo].[PUBLISHER] where PUB_ID = " + textBox20.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 0)
                {
                    sqlCommand.CommandText = "INSERT INTO PUBLISHER VALUES(" + textBox20.Text + ",'" + textBox19.Text + "','" + textBox18.Text + "')";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Insertion Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("\tThis Publisher ID is already exist\t");
                }

                sqlConenction.Close();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox20.Text == "" || textBox19.Text == "" || textBox18.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(PUB_ID) AS NumberOfStudent FROM [dbo].[PUBLISHER] where PUB_ID = " + textBox20.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 1)
                {
                    sqlCommand.CommandText = "UPDATE PUBLISHER SET NAME = '" + textBox19.Text + "' , ADDRESS = '" + textBox18.Text + "' where PUB_ID = " + textBox20.Text + "";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("\tThis Publisher ID is NOT Found\t");
                }

                sqlConenction.Close();
            }            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox20.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(PUB_ID) AS NumberOfStudent FROM [dbo].[PUBLISHER] where PUB_ID = " + textBox20.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 1)
                {
                    sqlCommand.CommandText = "DELETE FROM PUBLISHER where PUB_ID = " + textBox20.Text + "";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Delete Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("\tThis Publisher ID is NOT Found\t");
                }

                sqlConenction.Close();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pUBLISHERTableAdapter.Fill(this.library_Management_SystemDataSet.PUBLISHER);
        }

        private void pUBLISHERDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(textBox13.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(CAT_ID) AS NumberOfStudent FROM [dbo].[CATEGORY] where CAT_ID = " + textBox12.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 0)
                {
                    sqlCommand.CommandText = "INSERT INTO CATEGORY VALUES('" + textBox13.Text + "'," + textBox12.Text + ")";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Insertion Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("\tThis Category ID is already exsit\t");
                }

                sqlConenction.Close();
            }            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox13.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(CAT_ID) AS NumberOfStudent FROM [dbo].[CATEGORY] where CAT_ID = " + textBox12.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 1)
                {
                    sqlCommand.CommandText = "UPDATE CATEGORY SET NAME = '" + textBox13.Text + "' where CAT_ID = " + textBox12.Text + "";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("UPDATE Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("\tThis Category ID is NOT Found\t");
                }

                sqlConenction.Close();
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ( textBox12.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(CAT_ID) AS NumberOfStudent FROM [dbo].[CATEGORY] where CAT_ID = " + textBox12.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 1)
                {
                    sqlCommand.CommandText = "DELETE FROM CATEGORY where CAT_ID = " + textBox12.Text + "";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("DELETION Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("\tThis Category ID is NOT Found\t");
                }

                sqlConenction.Close();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.cATEGORYTableAdapter.Fill(this.library_Management_SystemDataSet.CATEGORY);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox25.Text == "" || textBox24.Text == "" || textBox23.Text == "" || textBox22.Text == "" || comboBox1.Text == "" || textBox17.Text == "" || textBox16.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                SqlCommand comma = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(STU_ID) AS NumberOfStudent FROM [dbo].[STUDENT] where STU_ID = " + textBox25.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 0)
                {
                    sqlCommand.CommandText = "INSERT INTO STUDENT VALUES(" + textBox25.Text + ",'" + textBox24.Text + "','" + textBox23.Text + "'," + textBox22.Text + ",'" + comboBox1.Text + "'," + textBox17.Text + ",'" + textBox16.Text + "')";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Insertion Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("Student Already Excist");
                }

                sqlConenction.Close();
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox25.Text == "" || textBox24.Text == "" || textBox23.Text == "" || textBox22.Text == "" || comboBox1.Text == "" || textBox17.Text == "" || textBox16.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();


                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(STU_ID) AS NumberOfStudent FROM [dbo].[STUDENT] where STU_ID = " + textBox25.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 1)
                {
                    sqlCommand.CommandText = "UPDATE STUDENT SET NAME = '" + textBox24.Text + "' , E_MAIl = '" + textBox23.Text + "', PHONE = " + textBox22.Text + ", SEX = '" + comboBox1.Text + "', DOB = " + textBox17.Text + " where STU_ID = " + textBox25.Text + "";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("This Student ID IS NOT Found");
                }

                sqlConenction.Close();
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox25.Text == "")
            {
                MessageBox.Show("\tenter full data\t");
            }
            else
            {
                SqlConnection sqlConenction = new SqlConnection(cn);
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConenction;
                sqlConenction.Open();

                comma.Connection = sqlConenction;
                comma.CommandText = ("SELECT COUNT(STU_ID) AS NumberOfStudent FROM [dbo].[STUDENT] where STU_ID = " + textBox25.Text + "");
                int tmp = (Int32)comma.ExecuteScalar();

                if (tmp == 1)
                {
                    sqlCommand.CommandText = "DELETE FROM STUDENT where STU_ID = " + textBox25.Text + "";
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Delete Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("This Student ID IS NOT Found");
                }

                sqlConenction.Close();
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.sTUDENTTableAdapter.Fill(this.library_Management_SystemDataSet.STUDENT);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Welcome f1 = new Welcome(cn);
            f1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Book Report")
            {
                Form1 fm = new Form1();
                fm.Show();

            }
            else if (comboBox2.Text == "Admin Report")
            {
                Form2 fm = new Form2();
                fm.Show();
            }

            else if (comboBox2.Text == "Student Report")
            {
                Form3 fm = new Form3();
                fm.Show();
            }

            else if (comboBox2.Text == "Professor Report")
            {
                Form4 fm = new Form4();
                fm.Show();
            }

            else if (comboBox2.Text == "Borrow Report")
            {
                Form5 fm = new Form5();
                fm.Show();
            }
            else if (comboBox2.Text == "Publisher Report")
            {
                Form6 fm = new Form6();
                fm.Show();
            }

        }
    }
}
