using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion.CLASES
{
    class CProductos
    {
        private string _CodigoP = "";
        private string _NombreP = "";
        private double _PrecioC = 0;
        private double _PrecioV = 0;
        private int _cantidad = 0;

        public CProductos()
        {
            _CodigoP = "";
            _NombreP = "";
            _PrecioC = 0;
            _PrecioV = 0;
            _cantidad = 0;
        }

        public string CodigoP
        {
            get { return _CodigoP; }
            set { _CodigoP = value; }
                     
        }
        public string NombreP
        {
            get { return _NombreP; }
            set { _NombreP = value; }

        }
        public double PrecioC
        {
            get { return _PrecioC; }
            set { _PrecioC = value; }

        }

        public double PrecioV
        {
            get { return _PrecioV; }
            set { _PrecioV = value; }

        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }

        }
    }
}
