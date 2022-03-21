using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion.CLASES
{
    class CProvedor
    {
        private string _nit = "";
        private string _nombre = "";
        private string _telefono = "";
        private string _direccion = "";
        private string _correo = "";
        public CProvedor()
        {
            _nit = "";
            _nombre = "";
            _telefono = "";
            _direccion = "";
            _correo = "";
        }
        public string Nit
        {
            get{ return _nit; }
            set{ _nit = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

    }
}
