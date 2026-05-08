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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FNPU8E8Q;Initial Catalog=School;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            String dt = Convert.ToString(dateTimePicker1.Value);


            string str = "insert into Login values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dt + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved successfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            dateTimePicker1.Value = Convert.ToDateTime("1/1/2000");


            comboBox1.Text = "Select";
            comboBox2.Text = "Select";
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();

            l.Show();
        }
    }
}
