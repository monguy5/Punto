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
    public partial class AgregarInventarioView : Form
    {
        AgregarInventarioVM ai;
        public AgregarInventarioView()
        {
            InitializeComponent();
            ai = new AgregarInventarioVM();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            VerInventariosView vi = new VerInventariosView();
            vi.Show();
            //this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
           lblestatus.Text= ai.insertar(txtdescripcion.Text,txtnomcorto.Text, Decimal.Parse(txtprecio.Text), Decimal.Parse(txtcantidad.Text),txtcodigo.Text);
        }
    }
}
