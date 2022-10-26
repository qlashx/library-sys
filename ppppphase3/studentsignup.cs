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
    public partial class studentsignup : Form
    {
        public studentsignup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
              SqlConnection con = new SqlConnection("Data Source=JOE-LABTOP;Initial Catalog=MovieAppDB;Integrated Security=True");
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TITLE,DESCRIPTION,LANGUAGE,RATING,RELEASEDATE,PRICE FROM MOVIE WHERE TITLE = '" + searchCriteia.Text + "'ORDER BY TITLE ", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable == null || dataTable.Rows.Count < 1)
                MessageBox.Show("Film With Name '" + searchCriteia.Text + "' Not Found");
            else
            {
                fimNameDataGridView.DataSource = dataTable;
                fimNameDataGridView.AutoResizeColumns();
            }
            con.Close();







             SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlCommand con = new SqlCommand("insert into Student values("+textBox1.Text+ ", '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', " + textBox9.Text + ", '" + textBox10.Text + "')", con);
            c.Open();
            con.ExecuteNonQuery();
            MessageBox.Show("sucsses");
            c.Close();
             */
            SqlConnection c = new SqlConnection("Data Source=LAPTOP-G1FSKRF4;Initial Catalog=ss;Integrated Security=True");
            SqlCommand con = new SqlCommand("insert into Student values(" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', " + textBox9.Text + ", '" + textBox10.Text + "')", c);
            SqlCommand r = new SqlCommand("select max(StudentID)from Student", c);
            c.Open();
            con.ExecuteNonQuery();
           int id =(int)r.ExecuteScalar();
            MessageBox.Show("sucsses add one to your id :"+id);
            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s=new Form1();
            s.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void studentsignup_Load(object sender, EventArgs e)
        {

        }
    }
}
