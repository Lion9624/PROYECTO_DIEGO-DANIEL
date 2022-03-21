using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Proyecto_Programacion
{
    
    public partial class FormIngreso : Form
    {
        
        FormPantalla_principal llamado;
        //static SqlConnection conn = new SqlConnection("server=DIEGO123\\SQLEXPRESS; database=Licorera1.0; integrated security= true ");

        public FormIngreso()
        {
            InitializeComponent();
            
            try
            {
               
                CLASES.Cslquniversal.Abrir();
                //conn.Open();

                //MessageBox.Show("CONEXION CON DB EXITOSA ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en conexion DB \n" + ex.Message);


            }
            CLASES.Cslquniversal.Cerrar();
            //conn.Close();
        }


        private void butIngresar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
              
                try
                {
                    CLASES.Cslquniversal.Abrir();
                    //MessageBox.Show("CONEXION CON DB EXITOSA ");
                    string consulta = "Select * from Usuarios where (usuario = '"+textBox1.Text+"'  and  clave= '"+textBox2.Text +"' ) ";
                    SqlCommand comando = new SqlCommand(consulta,CLASES.Cslquniversal.conn);
                    //comando.Parameters.AddWithValue("Usuario", textBox1.Text);
                    //comando.Parameters.AddWithValue("Clave", textBox2.Text);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);                    
                    adaptador.SelectCommand = comando;
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    SqlDataReader leer = comando.ExecuteReader();
                    while (leer.Read())
                    {
                        CLASES.C_Usuario.codrol = leer[0].ToString();
                        CLASES.C_Usuario.NumDocumento = leer[1].ToString();
                        CLASES.C_Usuario.Usuario = leer[2].ToString();
                        CLASES.C_Usuario.Contrasena = leer[3].ToString();
                        CLASES.C_Usuario.Nombre = leer[4].ToString();
                        CLASES.C_Usuario.Telefono = leer[5].ToString();
                        CLASES.C_Usuario.Correo = leer[6].ToString();
                    }
                    CLASES.Cslquniversal.Cerrar();


                    if (resultado.Rows.Count==1) 
                    {
                        try
                        {
                            llamado = new FormPantalla_principal();
                            llamado.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
    

                    }
                    else
                    {
                        MessageBox.Show("el usuario y/o clave incorrecto");
                    }

                }
                catch(Exception ex)
                {

                    MessageBox.Show($"{ex} ERROR", "MENSAJE DE ERROR", MessageBoxButtons.OK);
                    CLASES.Cslquniversal.Cerrar();
                }


            }
            else
            {
                MessageBox.Show("Debes llenar ambos campos", "MENSAJE DE ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}
