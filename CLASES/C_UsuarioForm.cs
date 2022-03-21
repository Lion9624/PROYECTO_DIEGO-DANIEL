using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion.CLASES
{
    class C_UsuarioForm
    {
        private string _codrol = "";
        private string _usuario = "";
        private string _nombre = "";
        private string _num_documento = "";
        private string _contrasena = "";
        private string _Correo = "";
        private string _telefono = "";

        public C_UsuarioForm()
        {
            _codrol = "";
            _nombre = "";
            _usuario = "";
            _num_documento = "";
            _contrasena = "";
            _Correo = "";
            _telefono = "";
        }

        public string codrol
        {
            get { return _codrol; }
            set { _codrol = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string NumDocumento
        {
            get { return _num_documento; }
            set { _num_documento = value; }
        }
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
    }
}
