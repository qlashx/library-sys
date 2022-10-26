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

namespace ppppphase3
{
    public partial class display_all : Form
    {
        public display_all()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void display_all_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlDataAdapter d = new SqlDataAdapter("SELECT  BookID,Title,Name as [Author name],Address as[Author Address] FROM Book LEFT OUTER JOIN Author on Book.AuthorID=Author.AuthorID ", c);
            DataTable DT = new DataTable();
            d.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin l = new adminlogin();
            l.Show();
        }
    }
}
