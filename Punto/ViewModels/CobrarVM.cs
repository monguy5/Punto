using Punto.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto.ViewModels
{
    public class CobrarVM
    {
        public   CobrarVM()
        {
            c = new Conexion();
            lvm = new BindingList<VentasModel>();

        }
        //VentasModel vm;
         BindingList<VentasModel> lvm;
        DataTable dti;
        VentasModel vm;
        InventarioModel im;
        string codigo;
         List<InventarioModel> lim;
        Conexion c;
        string query;
        public void llenainventario()
        {

            lim = new List<InventarioModel>();
            im = new InventarioModel();
            dti = new DataTable();
            query = string.Format("select * from inventarios");
            dti = c.tablas(query);
        //    MessageBox.Show(dti.Rows.Count.ToString());
            foreach(DataRow row in dti.Rows)
            {
                try { 
                im.Cantidad = Decimal.Parse(row["cantidad"].ToString());
                im.Codigo = row["codigo"].ToString();
                im.Nomcorto = row["nomcorto"].ToString();
                im.Precio = Double.Parse(row["precio"].ToString());
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                lim.Add(im);
            }

        }
        public bool terminarventa()
        {
            string query= string.Empty;
            string query2 = string.Empty;
            query = "insert into ventas(cantidad,codigo,preciounitario,totalsiniva,total,usuario,fecha) VALUES ";
            try
            {
               
               // query = "BEGIN ";
                foreach(var item in lvm)
                {
                    query += string.Format("({0},'{1}',{2},{3},{4},'{5}',NOW()), ",item.Cantidad,item.Codigo,item.Preciounitario,item.Totalsiniva,item.Total, item.Usuario) ;
                    //c.crud(query);
                    query2 = string.Format("update inventarios set cantidad= cantidad - {0} where codigo='{1}';",item.Cantidad, item.Codigo) ;
               c.crud(query2);

                }
       query = query.Substring(0,query.Length-2);
                //query += " END;";
                Console.WriteLine(query);
            c.crud(query);

           
               
            }catch(Exception e) {
                
            }

            return true;
        }
        public bool borrar(int col)
        {
            bool r;
            try
            {
                lvm.RemoveAt(col);
                r = true;
            }
            catch(Exception e)
            {
                r = false;
            }
            return r;
        }
        public BindingList<VentasModel> agregar(string codigo, string nomcorto, double cantidad, string usuario)
        {
            vm = new VentasModel();
          
            var q = (from y in lim
                    where y.Codigo == codigo
                    select new { y.Precio }).FirstOrDefault();
            vm.Codigo = codigo;
            vm.Cantidad = cantidad;
            vm.Preciounitario = q.Precio;
            vm.Totalsiniva = (cantidad * q.Precio) / 1.16;
            vm.Total = (cantidad * q.Precio);
            vm.Usuario = usuario;
            vm.Fecha = DateTime.Now;
         
            lvm.Add(vm);
          
            return lvm;
           
//vm.Fecha = null;

            
        }
        public void llenar()
        {

        }
        public string busqueda(string cod)
        {
            string[] s = new string[2];
          
            codigo = string.Empty;
            var q = (from y in lim
                    where y.Codigo == cod
                    select new { y.Nomcorto }).FirstOrDefault();
           // MessageBox.Show(q.Nomcorto);
          
         
            return q.Nomcorto ;

        }
    }
}
