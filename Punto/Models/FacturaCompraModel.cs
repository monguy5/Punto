using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto.Models
{
    class FacturaCompraModel
    {
        public string nofactura { get; set; }
        public DateTime fechaemision { get; set; }
        public string rfcemiso { get; set; }
        public double subtotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
        public List<VentasModel> cuerpo { get; set; }

    }
}
