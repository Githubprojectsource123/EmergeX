using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Demo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thani\Documents\EmergeX.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Missing Username or Password");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UserName ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {


                    Form5 obj = new Form5();
                    obj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                con.Close();
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.Show();
            this.Hide();
        }
    }
}