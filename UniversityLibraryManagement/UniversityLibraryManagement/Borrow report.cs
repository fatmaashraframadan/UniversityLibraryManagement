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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Library_Management_SystemDataSet.BORROWED_BY' table. You can move, or remove it, as needed.
            this.BORROWED_BYTableAdapter.Fill(this.Library_Management_SystemDataSet.BORROWED_BY);

            this.reportViewer1.RefreshReport();
        }
    }
}
