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
    public partial class deletestudent : Form
    {
        public deletestudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
                SqlCommand q = new SqlCommand("DELETE FROM Student Where StudentID=" + textBox1.Text + "", c);
                c.Open();
                q.ExecuteNonQuery();
                MessageBox.Show("deleted");
                c.Close();
            }
            catch
            {
                MessageBox.Show("this student borrowed a book and cant be deleted\n until he return it ");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void deletestudent_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlDataAdapter d = new SqlDataAdapter("SELECT *FROM Student ", c);
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlDataAdapter d = new SqlDataAdapter("SELECT *FROM Student ", c);
            DataSet ds = new System.Data.DataSet();
            d.Fill(ds,"Student");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
