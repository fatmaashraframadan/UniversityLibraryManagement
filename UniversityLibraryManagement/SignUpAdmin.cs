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
    public partial class SignUpAdmin : Form
    {
        bool signed = false;
        string cn = "";
        public SignUpAdmin(string c)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cn = c;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.ADMIN' table. You can move, or remove it, as needed.
            //this.aDMINTableAdapter.Fill(this.library_Management_SystemDataSet.ADMIN);
        }

        private void aDMINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aDMINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_Management_SystemDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox10.Text == "" || textBox9.Text == "" || textBox8.Text == "" || comboBox1.Text == "" || textBox3.Text =="" ||textBox4.Text == "" || textBox5.Text == "" ||  textBox2.Text =="")
            {
                MessageBox.Show("\tEnter full Information\t");
            }

            else
            {
                SqlConnection sqlconnection = new SqlConnection(cn);
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconnection;
                sqlconnection.Open();        

                SqlCommand cmd = sqlconnection.CreateCommand();
                cmd.CommandText = "select count(AD_ID) AS NumberOfADMIN from [ADMIN] where AD_ID = " + textBox1.Text + "";
                int temp = (Int32)cmd.ExecuteScalar();
                if (temp == 0)
                {
                    sqlcommand.CommandText = "insert into ADMIN values(" +textBox1.Text + ", '" + textBox10.Text + "', '" + textBox9.Text + "'," + textBox8.Text + ",'" + comboBox1.Text + "'," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + ",'" + textBox2.Text + "')";
                    sqlcommand.ExecuteNonQuery();
                    sqlconnection.Close();
                    signed = true;
                    MessageBox.Show("\tSigned up\t");
                }
                else
                {
                    MessageBox.Show("\tCheck Your ID!\t");
                }
                sqlconnection.Close();
                //Moving to next form.
                if (signed)
                {
                    Admin f11 = new Admin(cn);
                    f11.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.aDMINTableAdapter.Fill(this.library_Management_SystemDataSet.ADMIN);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome F = new Welcome(cn);
            F.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void aDMINDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                      
        }
    }
}
