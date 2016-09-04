using Punto.Models;
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
    public partial class CobrarView : Form
    {
        Conexion c;
        List<VentasModel> lvm;
        CobrarVM cvm;
        public CobrarView()
        {
           
           
            InitializeComponent();
            cvm = new CobrarVM();
            c = new Conexion();
            cvm.llenainventario();
            lvm = new List<VentasModel>();
           // dataGridView1.DataSource = cvm.lvm;
           // dataGridView1.DataSource = c.tablas("select * from inventarios");
        }

        private void CobrarView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            //lvm.Aggregate
            //  lvm.Aggregate();
            dataGridView1.Refresh();

            dataGridView1.DataSource= cvm.agregar(txtcodigo.Text, txtnomcorto.Text, Double.Parse(txtcantidad.Text), "default");
            dataGridView1.Refresh();
        }

        private void txtcodigo_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F10)
            {
                txtnomcorto.Text =
          cvm.busqueda(txtcodigo.Text);
                label4.Text = "";
            }
            else
            {
                label4.Text = "No se encontro en el catalogo";
            }
           
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (cvm.borrar(dataGridView1.CurrentCell.RowIndex))
            {
                label4.Text = "Eliminado satisfactoriamente";
            }
            else
            {
                label4.Text = "No se pudo eliminar";
            }
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            cvm.terminarventa();
        }
    }
}
