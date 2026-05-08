using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class SchoolMS : Form
    {
        public SchoolMS()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Staff ad = new Add_New_Staff();
            ad.Show();
           // this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Update_Staff ud = new Update_Staff();
            ud.Show();
        }

        private void SchoolMS_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayStaff ds = new DisplayStaff();
            ds.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Add_New_Staff ad = new Add_New_Staff();
            ad.Show();
            // this.Hide();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Update_Staff ud = new Update_Staff();
            ud.Show();
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayStudent dst = new DisplayStudent();
            dst.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStaff SD = new DeleteStaff();
            SD.Show();
        }

        private void displayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DisplayStaff ds = new DisplayStaff();
            ds.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteStaff SD = new DeleteStaff();
            SD.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Update_Student ust = new Update_Student();
            ust.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            ds.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad");
        }

        private void aboutProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AT = new About();
            AT.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
