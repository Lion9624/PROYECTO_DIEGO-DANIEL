using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Programacion
{
    public partial class FReportes : Form
    {
        public FReportes()
        {         
            InitializeComponent();
            Leer2();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Leer();
        }
        public void Leer()
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta = "select Num_Factura,fecha,total,cod_User,Cedula_c from Factura where fecha BETWEEN '"+dateTimeINICIO.Text+"' AND '"+dateTimeFIN.Text+"'";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                DataGridViewReporte.DataSource = resultado;
                CLASES.Cslquniversal.Cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }

        }
        public void Leer2()
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta = "SELECT * FROM Factura";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                DataGridViewReporte.DataSource = resultado;
                CLASES.Cslquniversal.Cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
        }
    }
}
