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
namespace School
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FNPU8E8Q;Initial Catalog=School;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("select*from Login where User_Name='"+textBox1.Text+"'and Password='"+textBox2.Text+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                SchoolMS ms = new SchoolMS();
                ms.Show();
            }
            else
            {
                MessageBox.Show("Incorrect User Id and Password!");

            }
            //MessageBox.Show("Connection successfully");

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
