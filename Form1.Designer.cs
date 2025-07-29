namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            Nombre = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(141, 153, 174);
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(536, 570);
            button1.Name = "button1";
            button1.Size = new Size(264, 48);
            button1.TabIndex = 0;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre.ForeColor = Color.FromArgb(44, 84, 109);
            Nombre.Location = new Point(55, 76);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(72, 18);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombres";
            Nombre.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(44, 84, 109);
            textBox1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.HighlightText;
            textBox1.Location = new Point(55, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 39);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(18, 34, 46);
            label6.Location = new Point(58, 22);
            label6.Name = "label6";
            label6.Size = new Size(317, 32);
            label6.TabIndex = 13;
            label6.Text = "REGISTRO DE USUARIO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(41, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 659);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 84, 109);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1285, 653);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(141, 153, 174);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(Nombre);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(451, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 506);
            panel3.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 84, 109);
            label1.Location = new Point(55, 142);
            label1.Name = "label1";
            label1.Size = new Size(73, 18);
            label1.TabIndex = 14;
            label1.Text = "Apellidos";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(44, 84, 109);
            textBox2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.HighlightText;
            textBox2.Location = new Point(55, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 39);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(44, 84, 109);
            label2.Location = new Point(55, 208);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 16;
            label2.Text = "Contraseña";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(44, 84, 109);
            textBox3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.HighlightText;
            textBox3.Location = new Point(55, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 39);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(44, 84, 109);
            label3.Location = new Point(55, 278);
            label3.Name = "label3";
            label3.Size = new Size(207, 18);
            label3.TabIndex = 18;
            label3.Text = "Confirmación de contraseña";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(44, 84, 109);
            textBox4.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.HighlightText;
            textBox4.Location = new Point(55, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(320, 39);
            textBox4.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(44, 84, 109);
            label4.Location = new Point(55, 345);
            label4.Name = "label4";
            label4.Size = new Size(46, 18);
            label4.TabIndex = 20;
            label4.Text = "Email";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(44, 84, 109);
            textBox5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = SystemColors.HighlightText;
            textBox5.Location = new Point(55, 368);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(320, 39);
            textBox5.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(44, 84, 109);
            label5.Location = new Point(55, 410);
            label5.Name = "label5";
            label5.Size = new Size(71, 18);
            label5.TabIndex = 15;
            label5.Text = "Teléfono";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(44, 84, 109);
            textBox6.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = SystemColors.HighlightText;
            textBox6.Location = new Point(55, 433);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(320, 39);
            textBox6.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 84, 109);
            ClientSize = new Size(1364, 719);
            Controls.Add(panel1);
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label Nombre;
        private TextBox textBox1;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox6;
    }
}
