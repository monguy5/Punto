using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto.Models
{
   public  class ClientesModel
    {
        public int tel { get; set; }
        public int idcliente { get; set; }
        public string rfc { get; set; }
        public string calle { get; set; }
        public string estado { get; set; }
        public string nombre { get; set; }
        public string noexterior { get; set; }
        public string nointerior { get; set; }
        public string colonia { get; set; }
        public string correo { get; set; }
        public int cp { get; set; }
        public string ciudad { get; set; }
    }
}
