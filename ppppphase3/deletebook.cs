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
    public partial class deletebook : Form
    {
        public deletebook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
                SqlCommand q = new SqlCommand("DELETE FROM Book Where BookID=" + textBox1.Text + "", c);

                c.Open();
                q.ExecuteNonQuery();
                MessageBox.Show("deleted");
                c.Close();
            }
            catch
            {
                MessageBox.Show("this book is borrowed ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlDataAdapter d = new SqlDataAdapter("SELECT *FROM Book ", c);
            DataSet ds = new System.Data.DataSet();
            d.Fill(ds,"Book");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void deletebook_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlDataAdapter d = new SqlDataAdapter("SELECT *FROM Book ", c);
            DataTable DT = new DataTable();
            d.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin l = new adminlogin();
            l.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
