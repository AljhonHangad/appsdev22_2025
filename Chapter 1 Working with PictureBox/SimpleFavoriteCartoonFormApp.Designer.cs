namespace WindowsFormsApp5
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
			this.view = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.CartooncomboBox = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// view
			// 
			this.view.Location = new System.Drawing.Point(16, 138);
			this.view.Name = "view";
			this.view.Size = new System.Drawing.Size(137, 46);
			this.view.TabIndex = 0;
			this.view.Text = "View";
			this.view.UseVisualStyleBackColor = true;
			this.view.Click += new System.EventHandler(this.view_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(16, 190);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(137, 46);
			this.clear.TabIndex = 1;
			this.clear.Text = "Clear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.DodgerBlue;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(30, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Select an item:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.DodgerBlue;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(354, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Image";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(199, 77);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(356, 257);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 5;
			this.pictureBox.TabStop = false;
			// 
			// CartooncomboBox
			// 
			this.CartooncomboBox.FormattingEnabled = true;
			this.CartooncomboBox.Location = new System.Drawing.Point(16, 77);
			this.CartooncomboBox.Name = "CartooncomboBox";
			this.CartooncomboBox.Size = new System.Drawing.Size(137, 21);
			this.CartooncomboBox.TabIndex = 6;
			this.CartooncomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.CartooncomboBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox);
			this.panel1.Controls.Add(this.view);
			this.panel1.Controls.Add(this.clear);
			this.panel1.Location = new System.Drawing.Point(86, 125);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(576, 380);
			this.panel1.TabIndex = 7;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(80, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(589, 34);
			this.label1.TabIndex = 8;
			this.label1.Text = "Simple Favorite Cartoon Character Picker";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(758, 546);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button view;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ComboBox CartooncomboBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}

