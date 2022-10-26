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
    public partial class loginstcs : Form
    {
        public loginstcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this .Hide();
            studnetworkcs f=new studnetworkcs(); ;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            group f=new group(); ;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this .Hide (); 
            Form1 f=new Form1();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide ();
            studnetworkcs f= new studnetworkcs();
            f.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide () ;
            group f=new group ();
            f.Show();
        }
    }
}
