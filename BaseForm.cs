using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class BaseForm : Form
    {
        protected Sidebar MenuLateral;
        protected Panel ContentPanel;

        public BaseForm()
        {
            // Sidebar
            MenuLateral = new Sidebar();
            MenuLateral.Dock = DockStyle.Left;
            this.Controls.Add(MenuLateral);

            // Panel de contenido
            ContentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(25, 0, 0, 0),
                BackColor = ColorTranslator.FromHtml("#2C546D")
            };
            this.Controls.Add(ContentPanel);
        }
    }
}
