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
    public partial class group : Form
    {
        public group()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection r = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlCommand con = new SqlCommand("insert into [Group] values(" + textBox1.Text + ", " + textBox2.Text + ", '" + textBox3.Text + "', '" + textBox4.Text + "')", r);
            r.Open();
            con.ExecuteNonQuery();
            MessageBox.Show("group created");
            r.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void group_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlDataAdapter d = new SqlDataAdapter("SELECT *FROM [Group] ", c);
            DataTable DT = new DataTable();
            d.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this .Hide();
            loginstcs f=new loginstcs();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlDataAdapter d = new SqlDataAdapter("SELECT *FROM [Group] ", c);
            DataSet ds = new System.Data.DataSet();
            d.Fill(ds, "[Group]");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
