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
    public partial class Professor : Form
    {
        string cs = "";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        string id = "";
        public Professor(string ID , string c)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            id = ID;
            cs = c;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.ADVANCE_BORROW' table. You can move, or remove it, as needed.
            //this.aDVANCE_BORROWTableAdapter.Fill(this.library_Management_SystemDataSet.ADVANCE_BORROW);
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.BOOK' table. You can move, or remove it, as needed.
           // this.bOOKTableAdapter.Fill(this.library_Management_SystemDataSet.BOOK);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconnection = new SqlConnection(cs);
            SqlCommand sqlcommand = new SqlCommand();
            DateTime dateNow = DateTime.Now;
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();

            //sqlcommand.CommandText = "insert into[library].[dbo].[STUDENT] values(" + textBox1.Text + ", '" + textBox10.Text + "', '" + textBox9.Text + "'," + textBox8.Text + ",'" + textBox7.Text + "'," + textBox3.Text + ",'" + textBox2.Text + "')";
            sqlcommand.CommandText = "INSERT INTO [dbo].[ADVANCE_BORROW] VALUES(" + id + ", " + textBox2.Text + ")";

            sqlcommand.ExecuteNonQuery();

            sqlconnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter.Fill(this.library_Management_SystemDataSet.BOOK);
        }

        //Search.
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(cs);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();

            //sqlcommand.CommandText = "insert into[library].[dbo].[STUDENT] values(" + textBox1.Text + ", '" + textBox10.Text + "', '" + textBox9.Text + "'," + textBox8.Text + ",'" + textBox7.Text + "'," + textBox3.Text + ",'" + textBox2.Text + "')";
            sqlcommand.CommandText = "select* from BOOK where TITLE like '" + textBox3.Text + "'";

            sqlcommand.ExecuteNonQuery();

            sqlconnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.ADVANCE_BORROW' table. You can move, or remove it, as needed.
            this.aDVANCE_BORROWTableAdapter.Fill(this.library_Management_SystemDataSet.ADVANCE_BORROW);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome f1 = new Welcome(cs);
            f1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(cs);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();

            //sqlcommand.CommandText = "insert into[library].[dbo].[STUDENT] values(" + textBox1.Text + ", '" + textBox10.Text + "', '" + textBox9.Text + "'," + textBox8.Text + ",'" + textBox7.Text + "'," + textBox3.Text + ",'" + textBox2.Text + "')";
            sqlcommand.CommandText = "select * from BOOK where TITLE like '" + textBox3.Text + "'";
            sqlcommand.ExecuteNonQuery();
            this.bOOKTableAdapter.Fill(this.library_Management_SystemDataSet.BOOK);
            sqlconnection.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from BOOK where TITLE like '" + textBox3.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || id == "")
            {
                MessageBox.Show("\tEnter full Information\t");
            }
            else
            {
                con = new SqlConnection(cs);               
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select count(ISBN) AS NumberOfADMIN from [ADVANCE_BORROW] where ISBN = " + textBox2.Text + " AND ID2 = " + id + " ";
                int temp = (Int32)cmd.ExecuteScalar();

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = "select count(ISBN) AS NumberOfADMIN from [BOOK] where ISBN = " + textBox2.Text + "";
                int temp2 = (Int32)cmd2.ExecuteScalar();

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandText = "select sum(AVAILABLE) AS NumberOfADMIN3 from [BOOK] where ISBN = " + textBox2.Text + " ";
                int temp3 = Convert.ToInt32(cmd3.ExecuteScalar());


                if (temp3 == 0)
                {
                    MessageBox.Show("\tNo Available Books!\t");
                }
                else if (temp == 0 && temp2 == 1)
                {
                    sqlCommand.CommandText = "INSERT INTO [dbo].[ADVANCE_BORROW] VALUES(" + id + ", " + textBox2.Text + ")";
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.CommandText = "UPDATE BOOK SET AVAILABLE = AVAILABLE - 1  WHERE ISBN = " + textBox2.Text + " ";
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("\tWrong ISBN!\t");
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.aDVANCE_BORROWTableAdapter.Fill(this.library_Management_SystemDataSet.ADVANCE_BORROW);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }
    }
}
