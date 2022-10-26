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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup s = new signup();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            f.Open();
            if (admin_rb.Checked)
            {
                SqlCommand fon = new SqlCommand("SELECT Password FROM Admin WHERE  AdminID=" + textBox1.Text, f);
                string p = (string)fon.ExecuteScalar();
                if (p == textBox2.Text)
                {
                    MessageBox.Show("login done ");
                    this.Hide();
                    adminlogin t = new adminlogin();
                    t.Show();
                }
                else
                {
                    MessageBox.Show("login denied");
                }
            }
            else
            {
                SqlCommand fon = new SqlCommand("SELECT Password FROM Student WHERE  StudentID=" + textBox1.Text, f);
                string p = (string)fon.ExecuteScalar();
                if (p == textBox2.Text)
                {
                    MessageBox.Show("login done ");
                    this.Hide();
                    loginstcs n=new loginstcs();
                    n.Show();
                }
                else
                {
                    MessageBox.Show("login denied");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
