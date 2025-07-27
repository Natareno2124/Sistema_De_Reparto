using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class FormPiloto : Form
    {
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboSexo;
        private ComboBox comboLicencia;
        private TextBox txtSucursal;
        private Button btnGuardar;
        private Button btnCancelar;


        public string NombresText
        {
            get => txtNombres.Text;
            set => txtNombres.Text = value;
        }

        public string ApellidosText
        {
            get => txtApellidos.Text;
            set => txtApellidos.Text = value;
        }

        public DateTime FechaNaciValue
        {
            get => dateTimePicker1.Value;
            set => dateTimePicker1.Value = value;
        }

        public string SexoValue
        {
            get => comboSexo.SelectedItem?.ToString();
            set => comboSexo.SelectedItem = value;
        }

        public string TipoLicenciaValue
        {
            get => comboLicencia.SelectedItem?.ToString();
            set => comboLicencia.SelectedItem = value;
        }

        public int IdSucursalValue
        {
            get
            {
                int.TryParse(txtSucursal.Text, out int id);
                return id;
            }
            set => txtSucursal.Text = value.ToString();
        }


        public FormPiloto()
        {
            this.Text = "Agregar / Editar Piloto";
            this.Size = new Size(300, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Crear controles
            txtNombres = new TextBox { Location = new Point(20, 20), Width = 240, PlaceholderText = "Nombres" };
            txtApellidos = new TextBox { Location = new Point(20, 60), Width = 240, PlaceholderText = "Apellidos" };
            dateTimePicker1 = new DateTimePicker { Location = new Point(20, 100), Width = 240, Format = DateTimePickerFormat.Short };

            comboSexo = new ComboBox { Location = new Point(20, 140), Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
            comboSexo.Items.AddRange(new string[] { "M", "F" });

            comboLicencia = new ComboBox { Location = new Point(20, 180), Width = 240, DropDownStyle = ComboBoxStyle.DropDownList };
            comboLicencia.Items.AddRange(new string[] { "A", "B", "C" });

            txtSucursal = new TextBox { Location = new Point(20, 220), Width = 240, PlaceholderText = "ID Sucursal" };

            btnGuardar = new Button { Text = "Guardar", Location = new Point(20, 270), Width = 110 };
            btnCancelar = new Button { Text = "Cancelar", Location = new Point(150, 270), Width = 110 };

            // Eventos 
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;

            this.Controls.AddRange(new Control[] {
                txtNombres, txtApellidos, dateTimePicker1,
                comboSexo, comboLicencia, txtSucursal,
                btnGuardar, btnCancelar
            });
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombresText) || string.IsNullOrWhiteSpace(ApellidosText))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboSexo.SelectedIndex == -1 || comboLicencia.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona Sexo y Tipo de Licencia.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


