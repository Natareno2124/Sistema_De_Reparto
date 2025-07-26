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
            this.Text = "PILOTOS";
            this.Size = new Size(1000, 600);

            // para que no choque con el sidebar
            int margenIzquierda = 200 + 100;

            // para que haya mas padding entre los nombres de las tablas y la info de las tablas 
            int espacioEntreControles = 30; // más separación

            // Panel superior
            Panel headerPanel = new Panel
            {
                Size = new Size(this.Width, 50),
                Dock = DockStyle.Top,
                BackColor = ColorTranslator.FromHtml("#8A97A8") // Color gris-azulado
            };


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
    }
}
