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
    public partial class Student : Form
    {

        string cs = "";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        string studentid = "";

        public Student(string id,string c)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            studentid = id;
            cs = c;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.BORROWED_BY' table. You can move, or remove it, as needed.
            //this.bORROWED_BYTableAdapter.Fill(this.library_Management_SystemDataSet.BORROWED_BY);
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.BOOK' table. You can move, or remove it, as needed.
            //this.bOOKTableAdapter.Fill(this.library_Management_SystemDataSet.BOOK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bOOKTableAdapter.Fill(this.library_Management_SystemDataSet.BOOK);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOOKTableAdapter.Fill(this.library_Management_SystemDataSet.BOOK);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //Form6 form2 = new Form6();
            //form6.Show();
            //this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Welcome form1 = new Welcome(cs);
            form1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || studentid == "")
            {
                MessageBox.Show("\tEnter full Information\t");
            }
            else
            {
                con = new SqlConnection(cs);
                DateTime dateNow = DateTime.Now;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;

                SqlCommand sqlCommand2 = new SqlCommand();
                sqlCommand2.Connection = con;
                con.Open();

                //to know if this student borrowed this book before or not
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select count(ISBN) AS NumberOfADMIN from [BORROWED_BY] where ISBN = " + textBox1.Text + " AND STU_ID = " + studentid + "";
                int temp = (Int32)cmd.ExecuteScalar();

                //if this book exist or not
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = "select count(ISBN) AS NumberOfADMIN2 from [BOOK] where ISBN = " + textBox1.Text + "";
                int temp2 = (Int32)cmd2.ExecuteScalar();

                //to conter how many versions are available of this book
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandText = "select sum(AVAILABLE) AS NumberOfADMIN3 from [BOOK] where ISBN = " + textBox1.Text + " ";
                int temp3 = Convert.ToInt32(cmd3.ExecuteScalar());

                               
                if (temp3 == 0)
                {
                    MessageBox.Show("\tNo Available Books!\t");
                }
                else if (temp == 0 && temp2 == 1)
                {
                    sqlCommand.CommandText = "INSERT INTO BORROWED_BY VALUES(" + studentid + "," + textBox1.Text + ",'" + dateNow + "','" + dateNow.AddDays(10) + "')";
                    sqlCommand2.CommandText = "UPDATE BOOK SET AVAILABLE = AVAILABLE - 1  WHERE ISBN = " + textBox1.Text + " ";
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand2.ExecuteNonQuery();
                    con.Close();                    
                }
                else
                {
                    MessageBox.Show("\tWrong ISBN!\t");
                }
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from BOOK where TITLE like '" + textBox2.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.bORROWED_BYTableAdapter.Fill(this.library_Management_SystemDataSet.BORROWED_BY);
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from BORROWED_BY where STU_ID = " + studentid + "", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BookByPublisher f6 = new BookByPublisher(cs, studentid);
            f6.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
