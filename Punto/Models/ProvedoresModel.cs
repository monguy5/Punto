using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto.Models
{
    class ProvedoresModel
    {
        public string rfc { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public Int32 telefono { get; set; }
        public int cp { get; set;}
        public string localidad { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }

    }
}
