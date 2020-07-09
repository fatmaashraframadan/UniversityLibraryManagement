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
    public partial class LogInStudent : Form
    {
        string cn = "";
        SqlConnection connection;
        public LogInStudent(string c)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cn = c;
            connection = new SqlConnection(cn);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.STUDENT' table. You can move, or remove it, as needed.
            //this.sTUDENTTableAdapter.Fill(this.library_Management_SystemDataSet.STUDENT);

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
                cmd.CommandText = "select count(STU_ID) AS NumberOfADMIN from [STUDENT] where STU_ID = " + textBox1.Text + " AND NAME = '" + textBox2.Text + "' ";
                int temp = (Int32)cmd.ExecuteScalar();
                if (temp == 1)
                {
                    string id = textBox1.Text;
                    Student f5 = new Student(id,cn);
                    f5.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("\tID NOT FOUND\t");
                }
                connection.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome f = new Welcome(cn);
            f.Show();
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
    }
}
