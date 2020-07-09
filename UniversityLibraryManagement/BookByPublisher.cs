using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Inner Join between (BOOK , PUBLISHER).
namespace UniversityLibraryManagement
{
    public partial class BookByPublisher : Form
    {

        string cs = "";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        string id = "";
        public BookByPublisher(string c,string i)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cs = c;
            id = i;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select [dbo].[BOOK].ISBN,[dbo].[BOOK].TITLE,[dbo].[PUBLISHER].NAME from [dbo].[BOOK] inner join [dbo].[PUBLISHER] on [dbo].[BOOK].PUB_ID = [dbo].[PUBLISHER].PUB_ID", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student f5 = new Student(id,cs);
            f5.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
