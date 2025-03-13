namespace SimpleFormsAppWithCheckedListBox1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.moviecheckedlistbox = new System.Windows.Forms.CheckedListBox();
			this.movielistbox = new System.Windows.Forms.ListBox();
			this.add = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// moviecheckedlistbox
			// 
			this.moviecheckedlistbox.FormattingEnabled = true;
			this.moviecheckedlistbox.Location = new System.Drawing.Point(34, 154);
			this.moviecheckedlistbox.Name = "moviecheckedlistbox";
			this.moviecheckedlistbox.Size = new System.Drawing.Size(201, 229);
			this.moviecheckedlistbox.TabIndex = 0;
			this.moviecheckedlistbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// movielistbox
			// 
			this.movielistbox.FormattingEnabled = true;
			this.movielistbox.Location = new System.Drawing.Point(297, 154);
			this.movielistbox.Name = "movielistbox";
			this.movielistbox.Size = new System.Drawing.Size(270, 186);
			this.movielistbox.TabIndex = 1;
			// 
			// add
			// 
			this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add.Location = new System.Drawing.Point(33, 408);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(201, 40);
			this.add.TabIndex = 2;
			this.add.Text = "Add";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.button1_Click);
			// 
			// delete
			// 
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.Location = new System.Drawing.Point(586, 153);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(164, 43);
			this.delete.TabIndex = 3;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// clear
			// 
			this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clear.Location = new System.Drawing.Point(586, 215);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(164, 43);
			this.clear.TabIndex = 4;
			this.clear.Text = "Clear All";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = " Movies/Series List";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(294, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(236, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = " My Programming Languages";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Location = new System.Drawing.Point(261, 106);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(13, 373);
			this.panel3.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(782, 100);
			this.panel1.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(26, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(588, 39);
			this.label3.TabIndex = 8;
			this.label3.Text = " SIMPLE FAVORITE MOVIE PICKER APP";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Location = new System.Drawing.Point(0, 99);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(782, 13);
			this.panel2.TabIndex = 12;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.Location = new System.Drawing.Point(0, 111);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(13, 373);
			this.panel4.TabIndex = 13;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.White;
			this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel5.Location = new System.Drawing.Point(769, 111);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(13, 373);
			this.panel5.TabIndex = 14;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel6.Location = new System.Drawing.Point(1, 465);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(782, 13);
			this.panel6.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Bisque;
			this.ClientSize = new System.Drawing.Size(782, 478);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.add);
			this.Controls.Add(this.movielistbox);
			this.Controls.Add(this.moviecheckedlistbox);
			this.Name = "Form1";
			this.Text = "Movie Form App";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox moviecheckedlistbox;
		private System.Windows.Forms.ListBox movielistbox;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
	}
}

