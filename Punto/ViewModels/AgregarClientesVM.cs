using Punto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto.ViewModels
{
    class AgregarClientesVM
    {
        Conexion c;
        string mensaje;
        public AgregarClientesVM() {
            c = new Conexion();
        }
        public string Agregar(string rfc, string calle, string estado, int cp, string tel, string correo, string ciudad, string nombre, string noext, string noint, string colonia)
        {
            string query = string.Empty;
         
            query = String.Format("insert into clientes(rfc,calle,estado,cp,tel,correo,ciudad,nombre,noext,noint,colonia) VALUES "+
                "('{0}','{1}','{2}',{3},{4},'{5}','{6}','{7}','{8}','{9}','{10}')",rfc,calle,estado,cp,tel,correo,ciudad,nombre,noext,noint,colonia);
            mensaje=c.crud(query);
            return mensaje;

        }
    }
}
