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
    public partial class adminsginupcs : Form
    {
        public adminsginupcs()
        {
            InitializeComponent();
        }

        private void adminsginupcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlCommand con = new SqlCommand("insert into Admin values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "')", c);
            SqlCommand r = new SqlCommand("select max(AdminID)from Admin", c);
            c.Open();
            con.ExecuteNonQuery();
            int id = (int)r.ExecuteScalar();
            MessageBox.Show("sucsses and your id is : "+id);
            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.Show();
        }
    }
}
