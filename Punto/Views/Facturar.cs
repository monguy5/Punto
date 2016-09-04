using Punto.ViewModels;
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
    public partial class Facturar : Form
    {
        Busquedas b;
        public Facturar()
        {
            InitializeComponent();
            b = new Busquedas();
        }

        private void txtrfc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtrfc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.F10)
            {
                dtcliente.DataSource = b.buscacliente(txtrfc.Text);
                if (dtcliente.Rows.Count > 1)
                {
                    label3.Text = "Cliente Encontrado: ";
                    // dtcliente.DataBindings =b.buscacliente(txtrfc.Text);
                    dtcliente.Refresh();

                }
                else
                {
                    label3.Text = "Cliente no encontrado";
                }

            }
        }

        private void Facturar_Load(object sender, EventArgs e)
        {

        }

        private void txtticket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
               
                if (b.cargaticket(Convert.ToInt32(txtticket.Text)).Count >= dataGridView1.Rows.Count)
                {
                    dataGridView1.DataSource = b.cargaticket(Convert.ToInt32(txtticket.Text));
                    label4.Text = "Ticket Agregado Satisfactoriamente";
                }
                else
                {
                    label4.Text = "No se encontro el ticket";
                }
            }
        }
    }
}
