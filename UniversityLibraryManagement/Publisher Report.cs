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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Library_Management_SystemDataSet.PUBLISHER' table. You can move, or remove it, as needed.
            this.PUBLISHERTableAdapter.Fill(this.Library_Management_SystemDataSet.PUBLISHER);

            this.reportViewer1.RefreshReport();
        }
    }
}
