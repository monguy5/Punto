using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto.Models
{
    public class VentasModel
    {
        private int _Idventas;
        private double _Cantidad;
        private string _Codigo;
        private double _Preciounitario;
        private double _Totalsiniva;
        private double _Total;
        private string _Usuario;
        private DateTime _Fecha;

        public int Idventas
        {
            get
            {
                return _Idventas;
            }

            set
            {
                _Idventas = value;
            }
        }

        public double Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }

        public string Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                _Codigo = value;
            }
        }

        public double Preciounitario
        {
            get
            {
                return _Preciounitario;
            }

            set
            {
                _Preciounitario = value;
            }
        }

        public double Totalsiniva
        {
            get
            {
                return _Totalsiniva;
            }

            set
            {
                _Totalsiniva = value;
            }
        }

        public double Total
        {
            get
            {
                return _Total;
            }

            set
            {
                _Total = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }
    }
}
