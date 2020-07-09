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
    public partial class SignUpProfessor : Form
    {
        bool signed = false;
        string cn = "";
        public SignUpProfessor(string c)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cn = c;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.PROFFESSOR' table. You can move, or remove it, as needed.
            this.pROFFESSORTableAdapter.Fill(this.library_Management_SystemDataSet.PROFFESSOR);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pROFFESSORTableAdapter.Fill(this.library_Management_SystemDataSet.PROFFESSOR);
        }

        private void pROFFESSORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROFFESSORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_Management_SystemDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.PROFFESSOR' table. You can move, or remove it, as needed.
            //this.pROFFESSORTableAdapter.Fill(this.library_Management_SystemDataSet.PROFFESSOR);

        }

        private void pROFFESSORDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            //if entered any character in the id box will be deleted
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome F = new Welcome(cn);
            F.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox10.Text == "" || textBox9.Text =="" || textBox8.Text == "" || comboBox1.Text == "" || textBox3.Text == "" || textBox2.Text =="")
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
                cmd.CommandText = "select count(ID2) AS NumberOfADMIN from [PROFFESSOR] where ID2 = " + textBox1.Text + "";
                int temp = (Int32)cmd.ExecuteScalar();
                if (temp == 0)
                {
                    sqlcommand.CommandText = "insert into PROFFESSOR values(" + textBox1.Text + ", '" + textBox10.Text + "', '" + textBox9.Text + "'," + textBox8.Text + ",'" + comboBox1.Text + "'," + textBox3.Text + ",'" + textBox2.Text + "')";
                    sqlcommand.ExecuteNonQuery();
                    sqlconnection.Close();
                    signed = true;//next button
                    MessageBox.Show("\tSigned up\t");
                }
                else
                {
                    MessageBox.Show("\tCheck Your ID!\t");
                }
                sqlconnection.Close();

                //moving to next form.
                if (signed)
                {
                    string id = textBox1.Text;
                    Professor f7 = new Professor(id,cn);
                    f7.Show();
                    this.Hide();
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
