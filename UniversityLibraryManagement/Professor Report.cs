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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Library_Management_SystemDataSet.PROFFESSOR' table. You can move, or remove it, as needed.
            this.PROFFESSORTableAdapter.Fill(this.Library_Management_SystemDataSet.PROFFESSOR);

            this.reportViewer1.RefreshReport();
        }
    }
}
