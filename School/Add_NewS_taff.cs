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
    public partial class Add_New_Staff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FNPU8E8Q;Initial Catalog=School;Integrated Security=True");
        public Add_New_Staff()
        {
            InitializeComponent();
        }
        string img;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
              con.Open();
              string gen;
                  if (radioButton1.Checked==true)
                  {
                      gen = "M";
                  }
                  else
                  {
                      gen = "F";
                  }
            String dt = Convert.ToString(dateTimePicker1.Value);


              string str = "insert into Staff values('" + textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + dt + "','" + gen + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "','" + textBox7.Text + "','" + img + "')";
              SqlCommand cmd = new SqlCommand(str, con);
              cmd.ExecuteNonQuery();
              MessageBox.Show("Data saved successfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            pictureBox1.Image = null;
            comboBox2.Text = "Select";
            
            
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image files(*.png;*.jpg;*.bmp;*.gif) | *.png;*.jpg;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                img = ofd.FileName;

            }
        }

        private void Add_New_Staff_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}