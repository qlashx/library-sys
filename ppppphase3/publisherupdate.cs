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
    public partial class publisherupdate : Form
    {
        public publisherupdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlCommand q = new SqlCommand("UPDATE Publisher SET Name='" + textBox2.Text + "',Address='" + textBox3.Text + "'where PublisherID =" + textBox1.Text + " ", c);
            c.Open();
            q.ExecuteNonQuery();
            MessageBox.Show("updated");
            c.Close();
        }

        private void publisherupdate_Load(object sender, EventArgs e)
        {
           SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlDataAdapter d = new SqlDataAdapter("SELECT *FROM Publisher ", c);
            DataTable DT = new DataTable();
            d.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlDataAdapter d = new SqlDataAdapter("SELECT *FROM Publisher ", c);
            DataSet ds = new System.Data.DataSet();
            d.Fill(ds, "Publisher");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin l = new adminlogin();
            l.Show();
        }
    }
}
