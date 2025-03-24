using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

			string[] cartoon = { "Spongebob", "Patrick", "Mr. Krabs", "Sandy" };
			CartooncomboBox.Items.AddRange(cartoon);

			CartooncomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			CartooncomboBox.SelectedIndex = 0;
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void view_Click(object sender, EventArgs e)
		{
			string selectedItem = CartooncomboBox.SelectedItem.ToString();

			switch (selectedItem)
			{
				case "Spongebob":
					pictureBox.Image = Image.FromFile(@"C:\APPSDEV ALJHON\spongebob2.jpg");
					break;

				case "Patrick":
					pictureBox.Image = Image.FromFile(@"C:\APPSDEV ALJHON\patrick.jpg");
					break;

				case "Mr. Krabs":
					pictureBox.Image = Image.FromFile(@"C:\APPSDEV ALJHON\mrkrabs.jpg");
					break;

				case "Sandy":
					pictureBox.Image = Image.FromFile(@"C:\APPSDEV ALJHON\sandy.jpg");
					break;

				default:
					pictureBox.Image = null;
					break;
			}
		}

		private void clear_Click(object sender, EventArgs e)
		{
			pictureBox.Image = null;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
