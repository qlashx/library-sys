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
    public partial class studnetworkcs : Form
    {
        public studnetworkcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void studnetworkcs_Load(object sender, EventArgs e)
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
            loginstcs l = new loginstcs();
            l.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection r= new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlCommand con = new SqlCommand("insert into [Borrow/Return] values(" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "','"+returndate.Text+ "', '" + textBox4.Text + "')", r);
            r.Open();
            con.ExecuteNonQuery();
            MessageBox.Show("reserved done");
            r.Close();

        }
    }
}
