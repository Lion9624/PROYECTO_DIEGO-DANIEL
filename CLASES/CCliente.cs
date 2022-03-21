using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion.CLASES
{
    class CCliente
    {
        private string _Cedula = "";
        private string _Nombres = "";
        private string _Telefono = "";
        private string _Corre = "";
        private string _Direccion = "";

        public CCliente()
        {
            _Cedula = "";
            _Nombres = "";
            _Telefono = "";
            _Corre = "";
            _Direccion = "";
        }

        public string Cedula_C
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }
        public string Nombre_C
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
        public string Telefono_C
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public string Correo_C
        {
            get { return _Corre; }
            set { _Corre = value; }

        }
        public string Dir_C
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
    }
}
