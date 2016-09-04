using Punto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto.ViewModels
{
    class Busquedas
    {
        Conexion c;
       List<ClientesModel> lcm;
        ClientesModel cm;
       BindingList<VentasModel> lvm;
            VentasModel vm;
        DataTable dt;
        public Busquedas() {
            c = new Conexion();
            lcm = new List<ClientesModel>() ;
            lvm = new BindingList<VentasModel>();
            cargacliente();
        }
        public void cargacliente()
        {
            dt = new DataTable();
            string query = string.Empty;
            query = string.Format("select * from Clientes");
          dt =  c.tablas(query);
     foreach(DataRow row in dt.Rows)
            {
                cm = new ClientesModel();
                cm.calle = row["calle"].ToString();
                cm.tel = int.Parse(row["tel"].ToString());
                cm.rfc = row["rfc"].ToString();
                cm.ciudad = row["ciudad"].ToString();
                cm.idcliente = int.Parse(row["idclientes"].ToString());
                cm.noexterior = row["noext"].ToString();
                cm.nointerior = row["noint"].ToString();
                cm.cp = int.Parse(row["cp"].ToString());
                cm.estado = row["estado"].ToString();
                cm.nombre = row["nombre"].ToString();
                lcm.Add(cm);
            }
           
            
        }

        public List<ClientesModel> buscacliente(string rfc) {
            var q = from x in lcm
                    where x.rfc == rfc
                    select x;

            return q.ToList();

        }
        public BindingList<VentasModel> cargaticket(int idventas)
        {
            dt = new DataTable();
            try
            {
                vm = new VentasModel();
              dt=c.tablas(String.Format("select * from ventas where idventas={0}", idventas));
              foreach(DataRow row in dt.Rows)
                {
                    vm.Cantidad = int.Parse(row["cantidad"].ToString());
                    vm.Idventas = int.Parse(row["idventas"].ToString());
                    vm.Preciounitario = double.Parse(row["preciounitario"].ToString());
                    vm.Totalsiniva = double.Parse(row["totalsiniva"].ToString());
                    vm.Total = int.Parse(row["total"].ToString());
                    vm.Fecha = DateTime.Parse(row["fecha"].ToString());
                    lvm.Add(vm);

                }
                MessageBox.Show(Convert.ToString(lvm.Count));
            }
            catch(Exception e) {

                Console.WriteLine(e.Message);
            }

            return lvm;
        }

    }
}
