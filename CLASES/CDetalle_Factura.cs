using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion.CLASES
{
    class CDetalle_Factura
    {
        private string _Num_Factura_D = "";
        private string _Cod_Prod_D = "";
        private string _Cantidad_D = "";
        private string _Valor_Und_D = "";

        public CDetalle_Factura()
        {
            _Num_Factura_D = "";
            _Cod_Prod_D = "";
            _Cantidad_D = "";
            _Valor_Und_D = "";
        }

        public string Num_Factura_D
        {
            get { return _Num_Factura_D; }
            set { _Num_Factura_D = value; }
        }
        public string Cod_Prod_D
        {
            get { return _Cod_Prod_D; }
            set { _Cod_Prod_D = value; }
        }
        public string Cantidad_D
        {
            get { return _Cantidad_D; }
            set { _Cantidad_D = value; }
        }
        public string Valor_Und
        {
            get { return _Valor_Und_D; }
            set { _Valor_Und_D = value; }
        }
    }
}
