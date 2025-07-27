using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Rutas : Form
    {

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnEliminar;


        private TextBox txtBuscar;
        private ComboBox cmbRutas;
        private ComboBox cmbOrdenar;
        private Panel panelFiltros;


        public Rutas()
        {
            InitializeComponent();
            Sidebar sidebar = new Sidebar();
            sidebar.Dock = DockStyle.Left; // Se pega al borde izquierdo
            this.Controls.Add(sidebar);




        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Rutas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           //pictureBox1.Image = Image.FromFile("C:\\Users\\WINDOWS\\Desktop\\Semestre 2 2025\\ANALISIS DE SISTEMAS 2\\Proyecto 1\\Sistema_De_Reparto\\bin\\Debug\\net8.0-windows\\img.png");

        }
    }
}
