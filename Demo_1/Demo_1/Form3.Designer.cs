﻿namespace Demo_1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Mongolian Baiti", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(161, 189);
            label5.Name = "label5";
            label5.Size = new Size(284, 43);
            label5.TabIndex = 43;
            label5.Text = "Create Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(249, 377);
            label3.Name = "label3";
            label3.Size = new Size(89, 26);
            label3.TabIndex = 35;
            label3.Text = "Password";
            label3.Click += label3_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 284);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 36;
            label1.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(125, 313);
            textBox1.MaxLength = 20;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 34);
            textBox1.TabIndex = 38;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(397, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(133, 662);
            button1.Name = "button1";
            button1.Size = new Size(344, 47);
            button1.TabIndex = 40;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonFace;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(125, 405);
            textBox2.MaxLength = 20;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(366, 34);
            textBox2.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox3);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(630, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 779);
            panel1.TabIndex = 48;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(52, 372);
            button2.Name = "button2";
            button2.Size = new Size(344, 55);
            button2.TabIndex = 32;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDarkDark;
            label7.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(102, 299);
            label7.Name = "label7";
            label7.Size = new Size(238, 23);
            label7.TabIndex = 31;
            label7.Text = "Login with your personal Info.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDarkDark;
            label6.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(94, 276);
            label6.Name = "label6";
            label6.Size = new Size(265, 23);
            label6.TabIndex = 30;
            label6.Text = "To keep connected with us please";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDarkDark;
            label4.Font = new Font("Mongolian Baiti", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(84, 207);
            label4.Name = "label4";
            label4.Size = new Size(292, 43);
            label4.TabIndex = 29;
            label4.Text = "Welcome Back!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(261, 464);
            label2.Name = "label2";
            label2.Size = new Size(61, 26);
            label2.TabIndex = 49;
            label2.Text = "E mail";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonFace;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(125, 492);
            textBox3.MaxLength = 50;
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(366, 34);
            textBox3.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(240, 545);
            label8.Name = "label8";
            label8.Size = new Size(129, 26);
            label8.TabIndex = 51;
            label8.Text = "Phone Number";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonFace;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(125, 573);
            textBox4.MaxLength = 20;
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(366, 34);
            textBox4.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Window;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(288, 723);
            label10.Name = "label10";
            label10.Size = new Size(84, 23);
            label10.TabIndex = 55;
            label10.Text = "Customer";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Window;
            label11.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(209, 723);
            label11.Name = "label11";
            label11.Size = new Size(83, 23);
            label11.TabIndex = 54;
            label11.Text = "Sign up as\r\n";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(230, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(172, 109);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 56;
            pictureBox4.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1090, 803);
            Controls.Add(pictureBox4);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private Button button1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox4;
    }
}