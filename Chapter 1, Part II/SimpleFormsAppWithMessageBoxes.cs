using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = fname.Text;
            string middlename = mname.Text;
            string lastname = lname.Text;
            string suffixValue = suffix.Text;

            
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hello There! {firstname} {middlename} {lastname} {suffixValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show($"You clicked No, action canceled.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
