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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addabook k = new addabook();
            k.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorupdate k=new authorupdate();
            k.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            publisherupdate k = new publisherupdate();
            k.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            deletebook f=new deletebook();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            deletestudent f = new deletestudent();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            display_all n=new display_all();
            n.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n=new Form1();
            n.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            group n = new group();
            n.Show();
        }
    }
}
