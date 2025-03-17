using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] food = { "Filipino", "Japanese", "Chinese", "Korean" };
            foodComboBox.Items.AddRange(food);

            foodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foodCheckedListBox1.CheckOnClick = true;


            foodComboBox.SelectedIndex = 0;
        }

        private void select_Click(object sender, EventArgs e)
        {
            string[] filipinoFoodList = { "Bulalo", "Kare-Kare", "Bicol Express", "Pinakbet" };
            string[] japaneseFoodList = { "Sushi ", "Ramen", "Sukiyaki" };
            string[] chineseFoodList = { "Kung Pao Chicken", "Sweet and Sour Pork" };
            string[] koreanFoodList = { "Samgyeopsal", "Bibimbap " };

            foodCheckedListBox1.Items.Clear();

            if (foodComboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                foodCheckedListBox1.Items.AddRange(filipinoFoodList);
            }
            else if (foodComboBox.SelectedItem.ToString().Contains("Japanese")) {
                foodCheckedListBox1.Items.AddRange(japaneseFoodList);
            }
            else if (foodComboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                foodCheckedListBox1.Items.AddRange(chineseFoodList);
            }
            else if (foodComboBox.SelectedItem.ToString().Contains("Korean"))
            {
                foodCheckedListBox1.Items.AddRange(koreanFoodList);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach (var item in foodCheckedListBox1.Items) {
                bool isSelected = foodCheckedListBox1.GetItemChecked(foodCheckedListBox1.Items.IndexOf(item));
                if (isSelected && !foodlistBox1.Items.Contains(item)) 
                { 

                    foodlistBox1.Items.Add(item);
                }
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (foodlistBox1.Items.Count >= 1)
            {
                foodlistBox1.Items.Remove(foodlistBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foodlistBox1.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
