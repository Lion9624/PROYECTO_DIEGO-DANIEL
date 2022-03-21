using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion.CLASES
{
    class C_Usuario
    {
       static private string _codrol = "";
       static private string _usuario = "";
       static private string _nombre = "";
       static private string _num_documento = "";
       static private string _contrasena = "";      
       static private string _Correo = "";
       static private string _telefono = "";

        public C_Usuario()
        {
            _codrol = "";
            _nombre = "";
            _usuario = "";
            _num_documento = "";
            _contrasena = "";
            _Correo = "";
            _telefono = "";
        }

        static public string codrol
        {
            get { return _codrol; }
            set { _codrol = value; }
        }
        static public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        static public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
        static public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }
        static public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        static public string NumDocumento
        {
            get { return _num_documento; }
            set { _num_documento = value; }
        }
        static public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
    }
}

