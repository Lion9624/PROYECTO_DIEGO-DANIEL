using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Programacion.CLASES
{
    class  Cslquniversal
    {
        //string consulta ="server=DIEGO123\\SQLEXPRESS; database=Licorera1.0; integrated security= true ";
       static public SqlConnection conn = new SqlConnection("server=Dain; database=Licorera; integrated security= true ");
        public Cslquniversal ()
        {
            
        }

        static public void Abrir()
        {
            conn.Open();
        }
        static public void Cerrar()
        {
            conn.Close();
        }

    }
}
