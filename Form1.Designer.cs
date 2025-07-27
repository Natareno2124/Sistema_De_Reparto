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
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(114, 437);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(231, 36);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre.ForeColor = Color.DarkBlue;
            Nombre.Location = new Point(74, 58);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(56, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombres";
            Nombre.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.HighlightText;
            textBox1.Location = new Point(74, 76);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SteelBlue;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(74, 131);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(74, 114);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.SteelBlue;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(74, 197);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(318, 23);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(74, 180);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.SteelBlue;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(74, 260);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(318, 23);
            textBox4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(74, 242);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 7;
            label3.Text = "Confirmar Contraseña";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.SteelBlue;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(74, 321);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(318, 23);
            textBox5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(74, 304);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "  E-mail";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.SteelBlue;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(74, 377);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(318, 23);
            textBox6.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(74, 360);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 11;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(105, 17);
            label6.Name = "label6";
            label6.Size = new Size(217, 30);
            label6.TabIndex = 13;
            label6.Text = "Resgisto de Usuario";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Nombre);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(416, 22);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(458, 486);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(1032, 340);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(125, 32);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(942, 188);
            button3.Name = "button3";
            button3.Size = new Size(111, 113);
            button3.TabIndex = 16;
            button3.Text = "Prueba sucursales";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1194, 539);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label Nombre;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
    }
}
