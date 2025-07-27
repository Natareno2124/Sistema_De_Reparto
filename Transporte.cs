using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Transporte : BaseForm
    {
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnEliminar;

        // asi si deja usar eso en todos lados y no solo en el onstrutor
        private TextBox txtBuscar;
        private ComboBox cmbRutas;
        private ComboBox cmbOrdenar;
        private Panel panelFiltros;


        public Transporte()
        {

            this.Text = "TRANSPORTE";
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

            // Botón hamburguesa
            Button btnMenu = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(10, 5),
                FlatStyle = FlatStyle.Flat,
                Image = Image.FromFile("img/menu.png"), // tu icono
                BackColor = Color.Transparent
            };

            btnMenu.FlatAppearance.BorderSize = 0;

            // Usuario con icono
            Label lblUsuario = new Label
            {
                Text = "User Administrador ▼",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(headerPanel.Width - 180, 15) // mover a la derecha
            };

            // Ajustar cuando cambie tamaño
            headerPanel.Resize += (s, e) => {
                lblUsuario.Location = new Point(headerPanel.Width - 180, 15);
            };

            //hr
            Panel linea = new Panel
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = ColorTranslator.FromHtml("#2C546D") // línea oscura
            };

            // Agregar controles
            headerPanel.Controls.Add(btnMenu);
            headerPanel.Controls.Add(lblUsuario);
            headerPanel.Controls.Add(linea);
            ContentPanel.Controls.Add(headerPanel);

            // Título debajo del header
            Label lblTitulo = new Label
            {
                Text = "TRANSPORTE",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#1F2A44"),
                AutoSize = true,
                Location = new Point(300, 30) // margen por el sidebar
            };
            ContentPanel.Controls.Add(lblTitulo);

            // ESTO HACE QUE EL LABEL DEL TITULO QUEDE EN EL HEADER
            headerPanel.Controls.Add(lblTitulo);
            lblTitulo.Location = new Point(240, 10); //horizontal el mas alto


            //ESSTO ES EL CONTENIDO DE LA PAGINA DE PILOTOVAS 

            //Panel de filtros
            Panel panelFiltros = new Panel
            {
                Size = new Size(750, 50),
                Location = new Point(margenIzquierda, 60),
                BackColor = Color.White
            };
            //llamamos la funcion de redondeo
            ContentPanel.Controls.Add(panelFiltros);
            this.Load += (s, e) => RedondearControl(panelFiltros, 15);

            // Campo de búsqueda
            txtBuscar = new TextBox
            {
                PlaceholderText = "Buscar por placa",
                Size = new Size(200, 30),
                Multiline = true, /// fuerza que sea mas alto
                Location = new Point(10, 10),
                BackColor = ColorTranslator.FromHtml("#76A2BE"),
                BorderStyle = BorderStyle.None,
                ForeColor = Color.Black,  // color del texto
                Font = new Font("Segoe UI", 12)
            };
            ContentPanel.Controls.Add(txtBuscar);
            this.Load += (s, e) => RedondearControl(txtBuscar, 15);

            this.Load += (s, e) => CentrarControles(panelFiltros);
            this.Resize += (s, e) => CentrarControles(panelFiltros);


            // el select de busqueda de tipo de rutas 
            cmbRutas = new ComboBox {
                Size = new Size(180, 30),
                Location = new Point(220, 10),
                DropDownStyle = ComboBoxStyle.DropDownList,
                DrawMode = DrawMode.OwnerDrawFixed,
                BackColor = ColorTranslator.FromHtml("#76A2BE"),
                ForeColor = Color.Black,  // color del texto
                Font = new Font("Segoe UI", 10)
            };
            ContentPanel.Controls.Add(cmbRutas);
            this.Load += (s, e) => RedondearControl(cmbRutas, 15);
            this.Load += (s, e) => CentrarControles(panelFiltros);
            this.Resize += (s, e) => CentrarControles(panelFiltros);

            cmbRutas.Items.AddRange(new string[] { "Seleccionar Sucursal", "Norte", "Sur", "EsteOeste" });
            cmbRutas.SelectedIndex = 0;

            Image[] iconos = new Image[]{
                Image.FromFile("img/filtrar.png"),
            };
            cmbRutas.DrawItem += (s, e) => {
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
            cmbOrdenar = new ComboBox
            {
                Size = new Size(180, 30),
                Location = new Point(420, 10), // posición
                DropDownStyle = ComboBoxStyle.DropDownList, // Solo seleccionar opciones
                FlatStyle = FlatStyle.Flat,
                BackColor = ColorTranslator.FromHtml("#76A2BE"),
                ForeColor = Color.Black,  // color del texto
                Font = new Font("Segoe UI", 10)
            };

            ContentPanel.Controls.Add(cmbOrdenar);
            this.Load += (s, e) => RedondearControl(cmbOrdenar, 15);
            this.Load += (s, e) => CentrarControles(panelFiltros);
            this.Resize += (s, e) => CentrarControles(panelFiltros);

            cmbOrdenar.Items.AddRange(new string[] { "Ordenar por: ID", "Ordenar por: Nombre", "Ordenar por: Placa", "Ordenar por: Estado" });
            cmbOrdenar.SelectedIndex = 0;
            cmbOrdenar.SelectedIndexChanged += (s, e) => {
                string opcion = cmbOrdenar.SelectedItem.ToString();
                MessageBox.Show("Elegiste: " + opcion);
            };

            //LLAMADO DE LAS FUNCIONES
            panelFiltros.Controls.AddRange(new Control[] { txtBuscar, cmbRutas, cmbOrdenar });

            // Tabla de pilotos
            DataGridView dgvPilotos = new DataGridView
            {
                Size = new Size(750, 450),
                BackgroundColor = ColorTranslator.FromHtml("#2C546D"),
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Location = new Point(margenIzquierda, panelFiltros.Location.Y + panelFiltros.Height + espacioEntreControles),
            };

            dgvPilotos.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            dgvPilotos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPilotos.ColumnHeadersHeight = 40;
            dgvPilotos.EnableHeadersVisualStyles = false;


            // Columnas
            string[] columnas = { "Placa", "Marca", "Modelo", "Color", "Sucursal", "Estado" };

            foreach (string col in columnas)
            {
                dgvPilotos.Columns.Add(col, col);
            }

            // Datos ejemplo

            dgvPilotos.Rows.Add("GHH1563", "Toyota", "Yaris", "Negro", "Central", "Disponible");
            dgvPilotos.Rows.Add("BGS4524", "Kia", "Picanto", "Rojo", "Norte", "Ocupado");



            ContentPanel.Controls.Add(panelFiltros);
            ContentPanel.Controls.Add(dgvPilotos);


            // LOS BOTONES DE ACCION
            btnAgregar = new Button()
            {
                Size = new Size(150, 40),//width height
                Image = Image.FromFile("img/agregar.png"),
                Text = "Agregar",
                ForeColor = Color.White,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                FlatStyle = FlatStyle.Flat
            };
            btnAgregar.FlatAppearance.BorderSize = 0;

            btnEditar = new Button()
            {
                Size = new Size(150, 40),
                Image = Image.FromFile("img/editar.png"),
                Text = "Editar",
                ForeColor = Color.White,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                FlatStyle = FlatStyle.Flat
            };
            btnEditar.FlatAppearance.BorderSize = 0;

            btnGuardar = new Button()
            {
                Size = new Size(150, 40),
                Image = Image.FromFile("img/guardar.png"),
                Text = "Guardar",
                ForeColor = Color.White,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                FlatStyle = FlatStyle.Flat
            };
            btnGuardar.FlatAppearance.BorderSize = 0;

            btnEliminar = new Button()
            {
                Size = new Size(150, 40),
                Image = Image.FromFile("img/eliminar.png"),
                Text = "Eliminar",
                ForeColor = Color.White,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                FlatStyle = FlatStyle.Flat
            };
            btnEliminar.FlatAppearance.BorderSize = 0;


            // Agregar los botones al ContentPanel
            ContentPanel.Controls.Add(btnAgregar);
            ContentPanel.Controls.Add(btnEditar);
            ContentPanel.Controls.Add(btnGuardar);
            ContentPanel.Controls.Add(btnEliminar);

            // Posicionar botones en el Load o Constructor (también en Resize)
            this.Load += (s, e) => PosicionarBotones();
            this.Resize += (s, e) => PosicionarBotones();
        }

        // redondeador
        /// - Referencia: https://stackoverflow.com/questions/1262344/how-do-i-make-a-panel-with-rounded-corners
        /// - Documentación oficial Region: https://learn.microsoft.com/en-us/dotnet/api/system.drawing.region
        public void RedondearControl(Control control, int radio){
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(control.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(control.Width - radio, control.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }

        private void CentrarControles(Panel panel) {
            Control[] controles = { txtBuscar, cmbRutas, cmbOrdenar };
            int espacio = 20;
            int anchoTotal = controles.Sum(c => c.Width) + espacio * (controles.Length - 1);
            int inicioX = (panel.Width - anchoTotal) / 2;
            int y = (panel.Height - txtBuscar.Height) / 2;
            for (int i = 0; i < controles.Length; i++) {
                controles[i].Location = new Point(inicioX, y);
                inicioX += controles[i].Width + espacio;
            }
        }

        private void PosicionarBotones()
        {
            int padding = 15;
            int x = ContentPanel.Width - padding;
            int y = ContentPanel.Height - 40 - padding;

            x -= btnEliminar.Width;
            btnEliminar.Location = new Point(x, y);

            x -= (btnGuardar.Width + padding);
            btnGuardar.Location = new Point(x, y);

            x -= (btnEditar.Width + padding);
            btnEditar.Location = new Point(x, y);

            x -= (btnAgregar.Width + padding);
            btnAgregar.Location = new Point(x, y);
        }
    }

}

