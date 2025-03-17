namespace WindowsFormsApp3
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
            this.label2 = new System.Windows.Forms.Label();
            this.foodComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.foodCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.foodlistBox1 = new System.Windows.Forms.ListBox();
            this.delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuisine";
            // 
            // foodComboBox
            // 
            this.foodComboBox.FormattingEnabled = true;
            this.foodComboBox.Location = new System.Drawing.Point(39, 202);
            this.foodComboBox.Name = "foodComboBox";
            this.foodComboBox.Size = new System.Drawing.Size(154, 21);
            this.foodComboBox.TabIndex = 2;
            this.foodComboBox.Text = "Filipino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Food List";
            // 
            // foodCheckedListBox1
            // 
            this.foodCheckedListBox1.FormattingEnabled = true;
            this.foodCheckedListBox1.Location = new System.Drawing.Point(249, 202);
            this.foodCheckedListBox1.Name = "foodCheckedListBox1";
            this.foodCheckedListBox1.Size = new System.Drawing.Size(224, 214);
            this.foodCheckedListBox1.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(249, 422);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(224, 45);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "My Favorite Food List";
            // 
            // foodlistBox1
            // 
            this.foodlistBox1.FormattingEnabled = true;
            this.foodlistBox1.Location = new System.Drawing.Point(538, 202);
            this.foodlistBox1.Name = "foodlistBox1";
            this.foodlistBox1.Size = new System.Drawing.Size(236, 277);
            this.foodlistBox1.TabIndex = 7;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(789, 176);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(104, 37);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(789, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(39, 232);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(154, 34);
            this.select.TabIndex = 10;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(212, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 406);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(499, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 406);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Moccasin;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 109);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Favorite Movie Picker";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(-1, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(933, 10);
            this.panel4.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(932, 599);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.foodlistBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.foodCheckedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foodComboBox);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "w";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox foodComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox foodCheckedListBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox foodlistBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}

