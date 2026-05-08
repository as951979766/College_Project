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
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FNPU8E8Q;Initial Catalog=School;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            con.Open();
            string str = "insert into Book values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved successfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           comboBox1.Text = "Select";
            con.Close();
        }
    }
}
