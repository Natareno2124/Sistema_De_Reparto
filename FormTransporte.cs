using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class FormVehiculo : Form
    {
        private TextBox txtPlaca;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtColor;
        private TextBox txtCapacidad;
        private TextBox txtSucursal;
        private ComboBox comboTipo;
        private ComboBox comboEstado;
        private Button btnGuardar;
        private Button btnCancelar;

        public int PlacaValue
        {
            get
            {
                int.TryParse(txtPlaca.Text, out int placa);
                return placa;
            }
            set => txtPlaca.Text = value.ToString();
        }

        public string MarcaValue
        {
            get => txtMarca.Text;
            set => txtMarca.Text = value;
        }

        public string ModeloValue
        {
            get => txtModelo.Text;
            set => txtModelo.Text = value;
        }

        public string ColorValue
        {
            get => txtColor.Text;
            set => txtColor.Text = value;
        }

        public string CapacidadValue
        {
            get => txtCapacidad.Text;
            set => txtCapacidad.Text = value;
        }

        public int IdSucursalValue
        {
            get
            {
                int.TryParse(txtSucursal.Text, out int sucursal);
                return sucursal;
            }
            set => txtSucursal.Text = value.ToString();
        }

        public int TipoValue
        {
            get => comboTipo.SelectedIndex >= 0 ? comboTipo.SelectedIndex + 1 : 0;
            set => comboTipo.SelectedIndex = value - 1;
        }

        public int EstadoValue
        {
            get => comboEstado.SelectedIndex >= 0 ? comboEstado.SelectedIndex + 1 : 0;
            set => comboEstado.SelectedIndex = value - 1;
        }

        public FormVehiculo()
        {
            // Configuraciones básicas del formulario
            this.Text = "Agregar / Editar Vehículo";
            this.Size = new Size(300, 450);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Crear controles

            txtPlaca = new TextBox { PlaceholderText = "Placa (solo números)", Location = new Point(20, 20), Width = 240 };
            txtMarca = new TextBox { PlaceholderText = "Marca", Location = new Point(20, 60), Width = 240 };
            txtModelo = new TextBox { PlaceholderText = "Modelo", Location = new Point(20, 100), Width = 240 };
            txtColor = new TextBox { PlaceholderText = "Color", Location = new Point(20, 140), Width = 240 };
            txtCapacidad = new TextBox { PlaceholderText = "Capacidad", Location = new Point(20, 180), Width = 240 };
            txtSucursal = new TextBox { PlaceholderText = "ID Sucursal", Location = new Point(20, 220), Width = 240 };

            comboTipo = new ComboBox { Location = new Point(20, 260), Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
            comboTipo.Items.AddRange(new string[] { "Automóvil", "Camión", "Motocicleta" }); // Ejemplo

            comboEstado = new ComboBox { Location = new Point(20, 300), Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
            comboEstado.Items.AddRange(new string[] { "Disponible", "En uso", "Mantenimiento" }); // Ejemplo

            btnGuardar = new Button { Text = "Guardar", Location = new Point(20, 350), Width = 110 };
            btnCancelar = new Button { Text = "Cancelar", Location = new Point(150, 350), Width = 110 };

            // Eventos botones
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;

            // Agregar controles
            this.Controls.AddRange(new Control[] {
                txtPlaca, txtMarca, txtModelo, txtColor, txtCapacidad, txtSucursal,
                comboTipo, comboEstado, btnGuardar, btnCancelar
            });
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtPlaca.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtColor.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text) || string.IsNullOrWhiteSpace(txtSucursal.Text))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboTipo.SelectedIndex == -1 || comboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona Tipo y Estado del Vehículo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSucursal.Text, out int sucursal) || sucursal <= 0)
            {
                MessageBox.Show("Por favor ingresa un ID válido para la sucursal.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
