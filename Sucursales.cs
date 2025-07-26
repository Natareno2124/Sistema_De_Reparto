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
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
            Sidebar menu = new Sidebar();
            this.Controls.Add(menu);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {

        }
    }
}
