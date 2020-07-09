using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibraryManagement
{
    public partial class Welcome : Form
    {
        string cn="";
        public Welcome(string c)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cn = c;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_Management_SystemDataSet.PROFFESSOR' table. You can move, or remove it, as needed.
            //this.pROFFESSORTableAdapter.Fill(this.library_Management_SystemDataSet.PROFFESSOR);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                LogInAdmin f8 = new LogInAdmin(cn);
                f8.Show();
                this.Hide();
            }

            if (radioButton1.Checked)
            {
                LogInStudent f9 = new LogInStudent(cn);
                f9.Show();
                this.Hide();
            }

            if (radioButton3.Checked)
            {
                LogInProfessor f10 = new LogInProfessor(cn);
                f10.Show();
                this.Hide();
            }
        }

        private void pROFFESSORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.pROFFESSORBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.library_Management_SystemDataSet);

        }

        private void pROFFESSORDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SignUpStudent F = new SignUpStudent(cn);
                F.Show();
                this.Hide();
            }

            if (radioButton3.Checked)
            {
                SignUpProfessor F = new SignUpProfessor(cn);
                F.Show();
                this.Hide();
            }

            if (radioButton2.Checked)
            {
                SignUpAdmin F = new SignUpAdmin(cn);
                F.Show();
                this.Hide();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
