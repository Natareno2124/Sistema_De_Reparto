using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Pilotos : BaseForm
    {
        public Pilotos()
        {

            this.Text = "PILOTOS";
            this.Size = new Size(1000, 600);

            // para que no choque con el sidebar
            int margenIzquierda = 200 + 100;


            //Panel de filtros
            Panel panelFiltros = new Panel
            {
                Size = new Size(750, 50),
                Location = new Point(margenIzquierda, 20),
            };

            // Campo de búsqueda
            TextBox txtBuscar = new TextBox
            {
                PlaceholderText = "Buscar por nombre",
                Size = new Size(200, 30),
                Location = new Point(10, 10)
            };

            // el select de busqueda de tipo de rusas 
            ComboBox cmbRutas = new ComboBox
            {
                Size = new Size(180, 30),
                Location = new Point(220, 10),
                DropDownStyle = ComboBoxStyle.DropDownList,
                DrawMode = DrawMode.OwnerDrawFixed
            };

            cmbRutas.Items.AddRange(new string[] { "Seleccionar Ruta", "Todas las rutas", "Recoleccion", "Entrega" });
            cmbRutas.SelectedIndex = 0;

            Image[] iconos = new Image[]
            {
                Image.FromFile("img/filtrar.png"),
            };
            cmbRutas.DrawItem += (s, e) =>
            {
                e.DrawBackground();

                if (e.Index >= 0)
                {
                    int margenDerecho = 10;
                    int anchoTextoMax = e.Bounds.Width - margenDerecho;

                    string texto = cmbRutas.Items[e.Index].ToString();
                    SizeF textoSize = e.Graphics.MeasureString(texto, e.Font);

                    using (Brush textoBrush = new SolidBrush(e.ForeColor))
                    {
                        e.Graphics.DrawString(texto, e.Font, textoBrush, e.Bounds.Left + 5, e.Bounds.Top + 4);
                    }
                }
                e.DrawFocusRectangle();
            };


            // Botón ordenar
            ComboBox cmbOrdenar = new ComboBox
            {
                Size = new Size(180, 30),
                Location = new Point(420, 10), // posición
                DropDownStyle = ComboBoxStyle.DropDownList, // Solo seleccionar opciones
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9)
            };

            cmbOrdenar.Items.AddRange(new string[] { "Ordenar por: ID", "Ordenar por: Nombre", "Ordenar por: Fecha", "Ordenar por: Ruta" });
            cmbOrdenar.SelectedIndex = 0;
            cmbOrdenar.SelectedIndexChanged += (s, e) =>
            {
                string opcion = cmbOrdenar.SelectedItem.ToString();
                MessageBox.Show("Elegiste: " + opcion);
            };


            //LLAMADO DE LAS FUNCIONES
            panelFiltros.Controls.AddRange(new Control[] { txtBuscar, cmbRutas, cmbOrdenar });

            // === Tabla de pilotos ===
            DataGridView dgvPilotos = new DataGridView
            {
                Size = new Size(750, 450),
                Location = new Point(margenIzquierda, 80),
                BackgroundColor = ColorTranslator.FromHtml("#2C546D"),
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Columnas
            string[] columnas = { "ID", "Nombre", "Fecha_Nac", "Ruta", "Sucursal", "NºEntregas", "Contacto" };
            foreach (string col in columnas)
            {
                dgvPilotos.Columns.Add(col, col);
            }

            // Datos ejemplo
            dgvPilotos.Rows.Add("001", "Juan Pérez", "15/03/1985", "Ruta Norte", "Central", "45", "555-1234");
            dgvPilotos.Rows.Add("002", "Ana Gómez", "22/07/1990", "Ruta Sur", "Norte", "32", "555-5678");

            // **IMPORTANTE: agregar a ContentPanel, NO a this.Controls**
            ContentPanel.Controls.Add(panelFiltros);
            ContentPanel.Controls.Add(dgvPilotos);

        }

        private void InitializeComponent()
        {

        }
    }
}
