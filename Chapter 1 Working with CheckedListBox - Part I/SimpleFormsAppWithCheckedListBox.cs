using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

			string[] movies = { "The Simpsons", "Rick and Morty", "Squid Game", "Venom" };
			moviecheckedlistbox.Items.AddRange(movies);

			moviecheckedlistbox.CheckOnClick = true;
        }

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (var movie in moviecheckedlistbox.Items) {
				bool isSelected = moviecheckedlistbox.GetItemChecked(moviecheckedlistbox.Items.IndexOf(movie));
				if (isSelected && !movielistbox.Items.Contains(movie)) {
					movielistbox.Items.Add(movie);
				}
			}
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void delete_Click(object sender, EventArgs e)
		{
			if (movielistbox.Items.Count >= 1) {
				movielistbox.Items.Remove(movielistbox.SelectedItem);
			}
		}

		private void clear_Click(object sender, EventArgs e)
		{
			movielistbox.Items.Clear();
		}
	}
}
