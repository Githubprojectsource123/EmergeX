using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Demo_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thani\Documents\EmergeX.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AdminTbl (UserName,Password,Email,Phone) values (@Un,@P,@E,@Ph)", con);
                    cmd.Parameters.AddWithValue("@Un", textBox1.Text);
                    cmd.Parameters.AddWithValue("@P", textBox2.Text);
                    cmd.Parameters.AddWithValue("@E", textBox3.Text);

                    cmd.Parameters.AddWithValue("@Ph", textBox4.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");
                    con.Close();

                    Form3 obj = new Form3();
                    obj.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
