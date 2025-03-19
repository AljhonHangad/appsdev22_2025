using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] phones = { "Iphone 16 Pro Max (255GB)", "Iphone 16 Pro (128GB)", "Iphone 16 Plus (128GB)", "Iphone 16 (128B)", "Iphone 16e (128B)" };
            listBox1.Items.AddRange(phones);

            string[] addOn = { "Apple Care Plus", "USB-C Charging Adapter", "MagSafe Charger (1M)" };
            checkedListBox1.Items.AddRange(addOn);

            string[] loan = { "12 Months", "24 Months", "30 Months", "36 Months" };
            comboBox1.Items.AddRange(loan);

            listBox1.SelectedItem = 0;
            checkedListBox1.SelectedItem = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Contains(listBox1.Text);
            if (listBox1.SelectedIndex == 0)
            {
                double val = 69990;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                double val = 84990;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                double val = 54990;
            }
            else if (listBox1.SelectedIndex == 3)
            {
                double val = 62990;
            }
            else if (listBox1.SelectedIndex == 4)
            {
                double val = 39990;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (checkedListBox1.SelectedIndex == 0)
            {
                double addVal = 2590;
            }
            else if (checkedListBox1.SelectedIndex == 0 && checkedListBox1.SelectedIndex == 1)
            {
                double addVal = 1990 + 2590;
            }
            else if (checkedListBox1.SelectedIndex == 1 && checkedListBox1.SelectedIndex == 2)
            {
                double addVal = 1990 + 2490;
            }
            else
            {
                double addVal = 1990 + 2490 + 2590;
            }
        }

        private void compute_Click(object sender, EventArgs e)
        {
            double result = addVal + val;
            MessageBox.Show($" ",{ result},"Greetings",MessageBoxButtons.OK,MessageBoxButtons.Information);
        }
    }
}