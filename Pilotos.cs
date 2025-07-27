using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public class Pilotos : BaseForm
    {
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnEliminar;

        private TextBox txtBuscar;
        private ComboBox cmbRutas;
        private ComboBox cmbOrdenar;
        private Panel panelFiltros;

        private DataGridView dgvPilotos;

        private PilotosDAO pilotosDAO = new PilotosDAO();


        public Pilotos()
        {
            this.Text = "PILOTOS";
            this.Size = new Size(1000, 600);

            int margenIzquierda = 200 + 100;
            int espacioEntreControles = 30;

            // Panel superior
            Panel headerPanel = new Panel
            {
                Size = new Size(this.Width, 50),
                Dock = DockStyle.Top,
                BackColor = ColorTranslator.FromHtml("#8A97A8") //gris
            };

            Button btnMenu = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(10, 5),
                FlatStyle = FlatStyle.Flat,
                Image = Image.FromFile("img/menu.png"),
                BackColor = Color.Transparent
            };
            btnMenu.FlatAppearance.BorderSize = 0;

            Label lblUsuario = new Label
            {
                Text = "User Administrador",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(headerPanel.Width - 180, 15)
            };


            // Referencia: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.onpaint?view=windowsdesktop-9.0
            PictureBox picFlecha = new PictureBox
            {
                Image = new Bitmap(Image.FromFile("img/iniciarsesion.png"), new Size(32, 32)),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(16, 16),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(lblUsuario.Right + 5, lblUsuario.Top + 2), // lo pone a la derecha del texto
                BackColor = Color.Transparent
            };

            // Ajustar posición al redimensionar
            headerPanel.Resize += (s, e) =>
            {
                lblUsuario.Location = new Point(headerPanel.Width - 180, 15);
                picFlecha.Location = new Point(lblUsuario.Right + 5, lblUsuario.Top + 2);
            };

            headerPanel.Controls.Add(lblUsuario);
            headerPanel.Controls.Add(picFlecha);


            Panel linea = new Panel{
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = ColorTranslator.FromHtml("#2C546D")
            };

            headerPanel.Controls.Add(btnMenu);
            headerPanel.Controls.Add(lblUsuario);
            headerPanel.Controls.Add(linea);
            ContentPanel.Controls.Add(headerPanel);

            Label lblTitulo = new Label
            {
                Text = "PILOTOS",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#1F2A44"),
                AutoSize = true,
                Location = new Point(300, 30)
            };
            headerPanel.Controls.Add(lblTitulo);
            lblTitulo.Location = new Point(240, 10);

            // Panel filtros
            Panel panelFiltros = new Panel
            {
                Size = new Size(750, 50),
                Location = new Point(margenIzquierda, 60),
            };
            ContentPanel.Controls.Add(panelFiltros);

            // Campo búsqueda
            txtBuscar = new TextBox
            {
                PlaceholderText = "Buscar por nombre",
                Size = new Size(200, 30),
                Multiline = true,
                Location = new Point(10, 10),
                BackColor = ColorTranslator.FromHtml("#8A97A8"),
                BorderStyle = BorderStyle.None,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 12)
            };
            ContentPanel.Controls.Add(txtBuscar);
            this.Load += (s, e) => CentrarControles(panelFiltros);
            this.Resize += (s, e) => CentrarControles(panelFiltros);

            // Combo rutas
            cmbRutas = new ComboBox
            {
                Size = new Size(180, 30),
                Location = new Point(220, 10),
                DropDownStyle = ComboBoxStyle.DropDownList,
                DrawMode = DrawMode.OwnerDrawFixed,
                BackColor = ColorTranslator.FromHtml("#8A97A8"),
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 10)
            };
            ContentPanel.Controls.Add(cmbRutas);
            this.Load += (s, e) => CentrarControles(panelFiltros);
            this.Resize += (s, e) => CentrarControles(panelFiltros);

            cmbRutas.Items.AddRange(new string[] { "Seleccionar Ruta", "Todas las rutas", "Recolección", "Entrega" });
            cmbRutas.SelectedIndex = 0;

            cmbRutas.DrawItem += (s, e) =>
            {
                e.DrawBackground();
                if (e.Index >= 0)
                {
                    string texto = cmbRutas.Items[e.Index].ToString();
                    using (Brush textoBrush = new SolidBrush(e.ForeColor))
                    {
                        e.Graphics.DrawString(texto, e.Font, textoBrush, e.Bounds.Left + 5, e.Bounds.Top + 4);
                    }
                }
                e.DrawFocusRectangle();
            };

            // Combo ordenar
            cmbOrdenar = new ComboBox
            {
                Size = new Size(180, 30),
                Location = new Point(420, 10),
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                BackColor = ColorTranslator.FromHtml("#8A97A8"),
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 10)
            };
            ContentPanel.Controls.Add(cmbOrdenar);
            this.Load += (s, e) => CentrarControles(panelFiltros);
            this.Resize += (s, e) => CentrarControles(panelFiltros);

            cmbOrdenar.Items.AddRange(new string[] { "Ordenar por: ID", "Ordenar por: Nombre", "Ordenar por: Fecha", "Ordenar por: Ruta" });
            cmbOrdenar.SelectedIndex = 0;

            panelFiltros.Controls.AddRange(new Control[] { txtBuscar, cmbRutas, cmbOrdenar });

            // Tabla
            dgvPilotos = new DataGridView
            {
                Size = new Size(750, 450),
                BackgroundColor = ColorTranslator.FromHtml("#FFFFFF"),
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Location = new Point(margenIzquierda, panelFiltros.Location.Y + panelFiltros.Height + espacioEntreControles),
                AutoGenerateColumns = true
            };

            ContentPanel.Controls.Add(panelFiltros);
            ContentPanel.Controls.Add(dgvPilotos);

            dgvPilotos.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            dgvPilotos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2C546D"); // Color que quieras
            dgvPilotos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Para el texto
            dgvPilotos.ColumnHeadersHeight = 40;
            dgvPilotos.EnableHeadersVisualStyles = false;
            dgvPilotos.GridColor = Color.White;
            //solo lineas verticales 
            dgvPilotos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            // color de las líneas
            dgvPilotos.GridColor = ColorTranslator.FromHtml("#CCCCCC");

            dgvPilotos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPilotos.MultiSelect = false; // Para que solo se seleccione una fila
            dgvPilotos.ReadOnly = true;    


            this.Load += (s, e) => MostrarConductores();

            // Botones
            btnAgregar = new Button()
            {
                Size = new Size(100, 80),
                Image = new Bitmap(Image.FromFile("img/agregar.png"), new Size(32, 32)),
                Text = "Agregar",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                TextImageRelation = TextImageRelation.ImageAboveText,
                TextAlign = ContentAlignment.BottomCenter,    
                ImageAlign = ContentAlignment.TopCenter,    
                FlatStyle = FlatStyle.Flat,
                Padding = new Padding(0, 0, 0, 25)           
            };
            btnAgregar.FlatAppearance.BorderSize = 0;

            btnEditar = new Button()
            {
                Size = new Size(100, 80),
                Image = new Bitmap(Image.FromFile("img/editar.png"),new Size(28, 28)),
                Text = "EDITAR",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                TextImageRelation = TextImageRelation.ImageAboveText,
                TextAlign = ContentAlignment.TopCenter,
                ImageAlign = ContentAlignment.TopCenter,
                FlatStyle = FlatStyle.Flat,
                Padding = new Padding(0, 0, 0, 25) // izquierda arriba derecha abajo

            };
            btnEditar.FlatAppearance.BorderSize = 0;

            btnGuardar = new Button()
            {
                Size = new Size(100, 80),
                Image = new Bitmap(Image.FromFile("img/guardar.png"), new Size(28, 28)),
                Text = "GUARDAR",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                TextImageRelation = TextImageRelation.ImageAboveText,
                TextAlign = ContentAlignment.TopCenter,
                ImageAlign = ContentAlignment.TopCenter,
                FlatStyle = FlatStyle.Flat,
                Padding = new Padding(0, 0, 0, 25) // izquierda arriba derecha abajo

            };
            btnGuardar.FlatAppearance.BorderSize = 0;

            btnEliminar = new Button()
            {
                Size = new Size(100, 80),
                Image = new Bitmap(Image.FromFile("img/eliminar.png"), new Size(28, 28)), // Imagen más pequeña
                Text = "ELIMINAR",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                TextImageRelation = TextImageRelation.ImageAboveText,
                TextAlign = ContentAlignment.TopCenter,
                ImageAlign = ContentAlignment.TopCenter,
                FlatStyle = FlatStyle.Flat,
                Padding = new Padding(0, 0, 0, 25) // izquierda arriba derecha abajo
            };
            btnEliminar.FlatAppearance.BorderSize = 0;

            ContentPanel.Controls.Add(btnAgregar);
            ContentPanel.Controls.Add(btnEditar);
            ContentPanel.Controls.Add(btnGuardar);
            ContentPanel.Controls.Add(btnEliminar);

            this.Load += (s, e) => PosicionarBotones();
            this.Resize += (s, e) => PosicionarBotones();

            // Conectar eventos CRUD
            btnAgregar.Click += BtnAgregar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnEliminar.Click += BtnEliminar_Click;
        }

        private void CentrarControles(Panel panel)
        {
            Control[] controles = { txtBuscar, cmbRutas, cmbOrdenar };
            int espacio = 20;
            int anchoTotal = controles.Sum(c => c.Width) + espacio * (controles.Length - 1);
            int inicioX = (panel.Width - anchoTotal) / 2;
            int y = (panel.Height - txtBuscar.Height) / 2;
            for (int i = 0; i < controles.Length; i++)
            {
                controles[i].Location = new Point(inicioX, y);
                inicioX += controles[i].Width + espacio;
            }
        }

        // Mostrar datos
        private void MostrarConductores()
        {
            dgvPilotos.DataSource = pilotosDAO.ObtenerPilotos();
        }

        private void PosicionarBotones()
        {
            int padding = 15;
            int x = ContentPanel.Width - padding;
            int y = ContentPanel.Height - 60 - padding;

            x -= btnEliminar.Width;
            btnEliminar.Location = new Point(x, y);

            x -= (btnGuardar.Width + padding);
            btnGuardar.Location = new Point(x, y);

            x -= (btnEditar.Width + padding);
            btnEditar.Location = new Point(x, y);

            x -= (btnAgregar.Width + padding);
            btnAgregar.Location = new Point(x, y);
        }

        // logica del crud 

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FormPiloto form = new FormPiloto();
            if (form.ShowDialog() == DialogResult.OK)
            {
                pilotosDAO.InsertarPiloto(form.NombresText, form.ApellidosText, form.FechaNaciValue, form.SexoValue, form.TipoLicenciaValue, form.IdSucursalValue);
                MostrarConductores();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPilotos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvPilotos.SelectedRows[0].Cells["id"].Value);
            string nombres = dgvPilotos.SelectedRows[0].Cells["nombres"].Value.ToString();
            string apellidos = dgvPilotos.SelectedRows[0].Cells["apellidos"].Value.ToString();
            DateTime fechaNaci = Convert.ToDateTime(dgvPilotos.SelectedRows[0].Cells["fechaNaci"].Value);
            string sexo = dgvPilotos.SelectedRows[0].Cells["sexo"].Value.ToString();
            string tipoLicencia = dgvPilotos.SelectedRows[0].Cells["tipoLicencia"].Value.ToString();
            int idSucursal = Convert.ToInt32(dgvPilotos.SelectedRows[0].Cells["idSucursal"].Value);

            FormPiloto form = new FormPiloto();

            //  datos propiedades del formulario
            form.NombresText = nombres;
            form.ApellidosText = apellidos;
            form.FechaNaciValue = fechaNaci;
            form.SexoValue = sexo;
            form.TipoLicenciaValue = tipoLicencia;
            form.IdSucursalValue = idSucursal;

            if (form.ShowDialog() == DialogResult.OK)
            {
                pilotosDAO.ModificarPiloto(id, form.NombresText, form.ApellidosText, form.FechaNaciValue, form.SexoValue, form.TipoLicenciaValue, form.IdSucursalValue);
                MostrarConductores();
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPilotos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPilotos.SelectedRows[0].Cells["id"].Value);
                if (MessageBox.Show("¿Eliminar este piloto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pilotosDAO.EliminarPiloto(id);
                    MostrarConductores();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar.");
            }
        }
    }
}