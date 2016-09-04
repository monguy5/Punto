using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto.Models;
namespace Punto.ViewModels
{
    class AgregarProveedorVM
    {
        Conexion c;
        ProvedoresModel pm;
        List<ProvedoresModel> lpm;
        public AgregarProveedorVM()
        {
            c = new Conexion();
                   }

        public string agregar(string rfc, string localidad, string estado, string pais, int cp, Int32 tel, string nombre,string direccion)
        {
            string mensaje= string.Empty;
            string query = string.Empty;
            try
            {
                query = string.Format("insert into proveedores(rfc,localidad,estado,pais,cp,tel,nombre,direccion) VALUES ('{0}','{1}','{2}','{3}',{4},{5},'{6}','{7}')",rfc,localidad,estado,pais,cp,tel,nombre,direccion);
                c.crud(query);
                mensaje = "Se ha agregado el proveedor con exito";
            }
           catch(Exception e)
            {
                mensaje = e.Message;
            }
            return mensaje;

        }
    }
}
