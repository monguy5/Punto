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

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerInventariosView f = new VerInventariosView();
            f.Show();
        }

        private void agregarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarInventarioView a = new AgregarInventarioView();
            a.Show();
            
        }

        private void agregarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProveedoresView a = new AgregarProveedoresView();
            a.Show();
        }

        private void corteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cierreDeDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
