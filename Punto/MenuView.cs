using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CobrarView cv = new CobrarView();
            cv.Show();
        }

        private void catalogo_Click(object sender, EventArgs e)
        {

        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturar f = new Facturar();
            f.Show();
        }
    }
}
