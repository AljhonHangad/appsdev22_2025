using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string FirstNameValue = fname.Text;
            string LastNameValue = lname.Text;
            MessageBox.Show($"Hello There! {FirstNameValue} {LastNameValue}","Greetings!", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }
    }
}
