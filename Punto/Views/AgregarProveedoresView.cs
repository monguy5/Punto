using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto.ViewModels;
namespace Punto
{
    public partial class AgregarProveedoresView : Form
    {
        AgregarProveedorVM apvm;
        public AgregarProveedoresView()
        {
            InitializeComponent();
            apvm = new AgregarProveedorVM();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcp.Clear() ;
            txtdire.Clear();
            txtrfc.Clear();
            txttel.Clear();
            txtnombre.Clear();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
           lblmsj.Text= apvm.agregar(txtrfc.Text, txtloc.Text, txtest.Text, txtpais.Text, Convert.ToInt32(txtcp.Text),Convert.ToInt32(txttel.Text), txtnombre.Text, txtdire.Text);
        }
    }
}
