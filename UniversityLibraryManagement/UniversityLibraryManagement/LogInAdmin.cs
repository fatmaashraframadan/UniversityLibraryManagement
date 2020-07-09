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
    public partial class LogInAdmin : Form
    {
        string cn="";
        SqlConnection connection;
        //SqlDataAdapter adapt;
        //DataTable dt;

        public LogInAdmin(string c)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cn = c;
            connection = new SqlConnection(cn);
        }        

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.ADMIN' table. You can move, or remove it, as needed.
            //this.aDMINTableAdapter.Fill(this.library_Management_SystemDataSet.ADMIN);

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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("\tEnter full Information\t");
            }
            else
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select count(AD_ID) AS NumberOfADMIN from [ADMIN] where AD_ID = " + textBox1.Text + " AND NAME = '" + textBox2.Text + "' ";
                int temp = (Int32)cmd.ExecuteScalar();
                if(temp == 1)
                {
                    Admin f11 = new Admin(cn);
                    f11.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("\tID NOT FOUND\t"); 
                }
                connection.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Home Button.
        private void button2_Click(object sender, EventArgs e)
        {
            Welcome f = new Welcome(cn);
            f.Show();
            this.Hide();
        }
    }
}
