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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FNPU8E8Q;Initial Catalog=School;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Open();
            string sql = "select* from Student where S_ID='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string sname = rd[1].ToString();
                string fname = rd[2].ToString();
                DateTime dob = Convert.ToDateTime(rd[4]); 

                textBox1.Text = sname;
                textBox2.Text = fname;
                dateTimePicker1.Value = dob;


            }
            con.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sid = comboBox1.Text;
            string qr = "Delete from Student where S_ID='" + sid + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted successfully...");
            comboBox1.Items.Clear();
            comboBox1.Text = "---select ID---";
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Items.Clear();
            dateTimePicker1.Value = Convert.ToDateTime("1/1/2000");
            con.Close();


            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add((ds.Tables[0].Rows[i][0]).ToString());
            }
            con.Close();


        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add((ds.Tables[0].Rows[i][0]).ToString());
            }
            con.Close();
        }
    }
}
