
namespace WinFormsApp1

{
    using System.Drawing;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.BackColor = ColorTranslator.FromHtml("#8D99AE");
            button1.BackColor = ColorTranslator.FromHtml("#8D99AE");
            BackColor = ColorTranslator.FromHtml("#2C546D");

            // esto es lo que agrega el side bar a la ventana 
            Sidebar menu = new Sidebar();
            this.Controls.Add(menu);
        }
        private void AplicarColorATextBox(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = ColorTranslator.FromHtml("#2C546D");
                }

                // Si el control contiene otros controles (ej. Panel, GroupBox)
                if (ctrl.HasChildren)
                {
                    AplicarColorATextBox(ctrl);
                }
            }
        }


        private void AplicarColorALabel(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.ForeColor = ColorTranslator.FromHtml("#183446");
                }

                // Si el control contiene otros controles (ej. Panel, GroupBox)
                if (ctrl.HasChildren)
                {
                    AplicarColorALabel(ctrl);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AplicarColorATextBox(this);
            AplicarColorALabel(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frmUsuarios = new Form2();
            frmUsuarios.Show(); // abre en ventana separada
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sucursales frmUsuarios = new Sucursales();
            frmUsuarios.Show(); // abre en ventana separada
        }
    }
}
