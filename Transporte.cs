using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Transporte : BaseForm
    {
        public Transporte()
        { 
            this.Text = "TRANSPORTE";
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
                PlaceholderText = "Buscar por marca",
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

            cmbRutas.Items.AddRange(new string[] { "Seleccionar Sucursal", "Sucursal 1", "Sucursal 2", "Sucursal 3" });
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

            // Tabla de pilotos
            DataGridView dgvPilotos = new DataGridView
            {
                Size = new Size(750, 450),
                Location = new Point(margenIzquierda, 80),
                BackgroundColor = ColorTranslator.FromHtml("#2C546D"),
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Columnas
            string[] columnas = { "Placa", "Marca", "Modelo", "Color", "Sucursal", "Estado"};
            foreach (string col in columnas)
            {
                dgvPilotos.Columns.Add(col, col);
            }

            // Datos ejemplo
            dgvPilotos.Rows.Add("PGSS478", "Toyota", "Yaris", "Negro", "Norte", "Disponible");
            dgvPilotos.Rows.Add("SJK4688", "Kia Picanto", "Nissan", "Rojo", "Sur", "Ocupado");

            ContentPanel.Controls.Add(panelFiltros);
            ContentPanel.Controls.Add(dgvPilotos);

        }
    }
}