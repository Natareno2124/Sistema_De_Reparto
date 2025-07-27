namespace WinFormsApp1
{
    partial class Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursales));
            label1 = new Label();
            bttFiltrar = new Button();
            bttGuardar = new Button();
            bttAgregar = new Button();
            bttEliminar = new Button();
            bttEditar = new Button();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(252, 80);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 0;
            label1.Text = "SUCURSALES";
            label1.Click += label1_Click;
            // 
            // bttFiltrar
            // 
            bttFiltrar.BackColor = Color.LightSteelBlue;
            bttFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttFiltrar.ImageAlign = ContentAlignment.MiddleRight;
            bttFiltrar.Location = new Point(257, 570);
            bttFiltrar.Name = "bttFiltrar";
            bttFiltrar.Size = new Size(125, 36);
            bttFiltrar.TabIndex = 1;
            bttFiltrar.Text = "Filtrar";
            bttFiltrar.UseVisualStyleBackColor = false;
            // 
            // bttGuardar
            // 
            bttGuardar.BackColor = Color.LightSteelBlue;
            bttGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            bttGuardar.Location = new Point(695, 580);
            bttGuardar.Name = "bttGuardar";
            bttGuardar.Size = new Size(80, 26);
            bttGuardar.TabIndex = 2;
            bttGuardar.Text = "Guardar";
            bttGuardar.UseVisualStyleBackColor = false;
            // 
            // bttAgregar
            // 
            bttAgregar.BackColor = Color.LightSteelBlue;
            bttAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            bttAgregar.Location = new Point(517, 580);
            bttAgregar.Name = "bttAgregar";
            bttAgregar.Size = new Size(80, 26);
            bttAgregar.TabIndex = 3;
            bttAgregar.Text = "Agregar";
            bttAgregar.UseVisualStyleBackColor = false;
            // 
            // bttEliminar
            // 
            bttEliminar.BackColor = Color.LightSteelBlue;
            bttEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            bttEliminar.Location = new Point(783, 580);
            bttEliminar.Name = "bttEliminar";
            bttEliminar.Size = new Size(80, 26);
            bttEliminar.TabIndex = 4;
            bttEliminar.Text = "Eliminar";
            bttEliminar.UseVisualStyleBackColor = false;
            // 
            // bttEditar
            // 
            bttEditar.BackColor = Color.LightSteelBlue;
            bttEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            bttEditar.Location = new Point(608, 580);
            bttEditar.Name = "bttEditar";
            bttEditar.Size = new Size(80, 26);
            bttEditar.TabIndex = 5;
            bttEditar.Text = "Editar";
            bttEditar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 112);
            label2.Name = "label2";
            label2.Size = new Size(622, 15);
            label2.TabIndex = 6;
            label2.Text = "---------------------------------------------------------------------------------------------------------------------------";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 54);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(252, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 47);
            panel2.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(527, 13);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 5;
            label8.Text = "Horario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(410, 13);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 4;
            label7.Text = "Contacto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(298, 13);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 3;
            label6.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(170, 13);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 2;
            label5.Text = "Encargado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(73, 13);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 1;
            label4.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(22, 13);
            label3.Name = "label3";
            label3.Size = new Size(32, 25);
            label3.TabIndex = 0;
            label3.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(252, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(622, 340);
            dataGridView1.TabIndex = 9;
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(948, 634);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(bttEditar);
            Controls.Add(bttEliminar);
            Controls.Add(bttAgregar);
            Controls.Add(bttGuardar);
            Controls.Add(bttFiltrar);
            Controls.Add(label1);
            Name = "Sucursales";
            Text = "Sucursales";
            Load += Sucursales_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bttFiltrar;
        private Button bttGuardar;
        private Button bttAgregar;
        private Button bttEliminar;
        private Button bttEditar;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
    }
}