using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion.CLASES
{
    class CFactura
    {
        private string _Num_Factura = "";
        private string _Fecha = "";
        private string _Total = "";
        private string _Cod_user = "";
        private string _Cedula_Cliente = "";

        public CFactura()
        {
            _Num_Factura = "";
            _Fecha = "";
            _Total = "";
            _Cod_user = "";
            _Cedula_Cliente = "";
        }
        public string Num_Factura
        {
            get { return _Num_Factura; }
            set { _Num_Factura = value; }
        }
        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public string Total_F
        {
            get { return _Total; }
            set { _Total = value; }
        }
        public string Cod_User
        {
            get { return _Cod_user; }
            set { _Cod_user = value; }
        }
        public string Cedula_Cliente
        {
            get { return _Cedula_Cliente; }
            set { _Cedula_Cliente = value; }
        }
    }
}
