using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Sidebar menu = new Sidebar();
            this.Controls.Add(menu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clases.CConexion conexion = new Clases.CConexion();
            conexion.establecerConexion();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
