using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Punto
{
    public partial class VerInventariosView : Form
    {
        VerInventarioVM vi;
       
        public VerInventariosView()
        {
            InitializeComponent();
            vi = new VerInventarioVM();
        }

        private void VerInventariosView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= vi.llenar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {

            
        }
    }
}
