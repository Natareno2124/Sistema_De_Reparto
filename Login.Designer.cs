namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            button2 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(141, 153, 174);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(383, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 349);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(18, 34, 46);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(87, 227);
            panel4.Name = "panel4";
            panel4.Size = new Size(50, 39);
            panel4.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(44, 84, 109);
            textBox2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(143, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 39);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 34, 46);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(87, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(50, 39);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(44, 84, 109);
            textBox1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(143, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 39);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(18, 34, 46);
            label1.Location = new Point(168, 114);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = "INICIAR SESIÓN";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 34, 46);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(574, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 161);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(141, 153, 174);
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(539, 507);
            button1.Name = "button1";
            button1.Size = new Size(242, 60);
            button1.TabIndex = 1;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(34, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(1291, 659);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(44, 84, 109);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(panel1);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1285, 653);
            panel6.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(44, 84, 109);
            button2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(716, 583);
            button2.Name = "button2";
            button2.Size = new Size(117, 29);
            button2.TabIndex = 3;
            button2.Text = "Regístrate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(521, 588);
            label2.Name = "label2";
            label2.Size = new Size(195, 19);
            label2.TabIndex = 2;
            label2.Text = "¿No tienes una cuenta?";
            label2.Click += label2_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 84, 109);
            ClientSize = new Size(1364, 719);
            Controls.Add(panel5);
            ForeColor = Color.FromArgb(44, 84, 109);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private Panel panel3;
        private TextBox textBox1;
        private Button button1;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Button button2;
    }
}