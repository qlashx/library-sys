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
    public partial class addabook : Form
    {
        public addabook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            c.Open();
            SqlCommand con = new SqlCommand("insert into Author values('" + textBox1.Text + "', '" + textBox2.Text + "')", c);
            con.ExecuteNonQuery();
            SqlCommand con2 = new SqlCommand("select max(AuthorID)from Author", c);

            int authorid =(int)con2.ExecuteScalar();
            SqlCommand co = new SqlCommand("insert into Publisher values('"+ textBox4.Text + "', '" + textBox5.Text + "')", c);
            co.ExecuteNonQuery();
            SqlCommand o = new SqlCommand("select max(PublisherID)from Publisher", c);
            int h = (int)o.ExecuteScalar();
            SqlCommand ce = new SqlCommand("insert into Book values("+h+", "+authorid+"," + textBox3.Text+",'" + textBox6.Text + "', '" + textBox7.Text + "')", c);
            ce.ExecuteNonQuery();
            MessageBox.Show("sucsses add");
            c.Close();
        }

        private void addabook_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin l = new adminlogin();
            l.Show();   
        }
    }
}
