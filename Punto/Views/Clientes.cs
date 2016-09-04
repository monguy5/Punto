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
    public partial class Clientes : Form
    {
        Conexion c;
        AgregarClientesVM acvm;
        public Clientes()
        {
            InitializeComponent();
            c = new Conexion();
            acvm = new AgregarClientesVM();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
           
           label12.Text= acvm.Agregar(txtrfc.Text,txtcalle.Text,txtestado.Text,int.Parse(txtcp.Text),txttel.Text,txtemail.Text,txtciudad.Text,txtnombre.Text,txtnoext.Text,txtnoint.Text,txtcol.Text);

        }
    }
}
