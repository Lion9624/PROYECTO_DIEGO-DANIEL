using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Programacion
{
    public partial class FormNew_Usuario : Form
    {
        
        //SqlConnection conn = new SqlConnection("server=DIEGO123\\SQLEXPRESS; database=Licorera1.0; integrated security= true ");
        CLASES.C_UsuarioForm Obj_Usuario = new CLASES.C_UsuarioForm();
        public FormNew_Usuario()
        {
            InitializeComponent();
            try
            {

                CLASES.Cslquniversal.Abrir();
                //MessageBox.Show("CONEXION CON DB EXITOSA ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en conexion DB \n" + ex.Message);


            }
            CLASES.Cslquniversal.Cerrar();
        }

        private void labTelefono_Click(object sender, EventArgs e)
        {

        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAgregarU_Click(object sender, EventArgs e)
        {
            int comprobar = 0;
            try
            {
                if (texbID_Usuario.Text == "" || texbNombre.Text == "" || texbNew_usuario.Text == "" || texbCorreo.Text == ""||texbTelefono.Text==""||texbcontrasena.Text==""||texbconfirmar.Text==""|| radBAdmin.Checked==false && radBvendedor.Checked==false)
                {
                    MessageBox.Show("Los Campos Marcados Con * Son Obligatorios");
                }
                else
                {
                    if (texbcontrasena.Text!=texbconfirmar.Text)
                    {
                        MessageBox.Show("las contraseñas no coinciden");
                    }
                    else
                    {
                        if (texbCorreo.Text.IndexOf('@') < 0)
                        {
                            MessageBox.Show("Correo electronico con formato incorrecto");
                        }
                        else
                        {
                            if (int.TryParse(texbTelefono.Text, out comprobar))
                            {
                                try
                                {
                                    CLASES.Cslquniversal.Abrir();
                                    //MessageBox.Show("CONEXION CON DB EXITOSA ");
                                    string consulta = "Select * from Usuarios where id_usuario = '" + texbID_Usuario.Text + "'";
                                    SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                                    //comando.Parameters.AddWithValue("Usuario", textBox1.Text);
                                    //comando.Parameters.AddWithValue("Clave", textBox2.Text);
                                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                                    adaptador.SelectCommand = comando;
                                    DataTable resultado = new DataTable();
                                    adaptador.Fill(resultado);
                                    CLASES.Cslquniversal.Cerrar();
                                    if (resultado.Rows.Count == 0)
                                    {
                                        int rol = 0;
                                        if (radBAdmin.Checked == true)
                                        {
                                            rol = 1;
                                        }
                                        else
                                        {
                                            rol = 2;
                                        }
                                        CLASES.Cslquniversal.Abrir();
                                        string consulta1 = "Insert into Usuarios values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                                        SqlCommand comando1 = new SqlCommand(consulta1, CLASES.Cslquniversal.conn);
                                        comando1.Parameters.AddWithValue("p1", rol);
                                        comando1.Parameters.AddWithValue("p2", texbID_Usuario.Text);
                                        comando1.Parameters.AddWithValue("p3", texbNew_usuario.Text);
                                        comando1.Parameters.AddWithValue("p4", texbcontrasena.Text);
                                        comando1.Parameters.AddWithValue("p5", texbNombre.Text);
                                        comando1.Parameters.AddWithValue("p6", texbTelefono.Text);
                                        comando1.Parameters.AddWithValue("p7", texbCorreo.Text);
                                        comando1.ExecuteNonQuery();
                                        CLASES.Cslquniversal.Cerrar();
                                        MessageBox.Show("usuario agregado");
                                        limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("el usuario que intentas registrar ya esta registrado ");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"{ex} ERROR", "MENSAJE DE ERROR", MessageBoxButtons.OK);
                                    //MessageBox.Show( EX.Message, "MENSAJE DE ERROR" , MessageBoxButtons.OK);
                                    CLASES.Cslquniversal.Cerrar();

                                }
                            }
                            else
                            {
                                MessageBox.Show("Numero telefono con formato incorrecto ");
                            }
                        }
     
           
                    }
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void texbContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void butBUSCAR_U_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (textBBuscar_usuario.Text!="")
                {
                    CLASES.Cslquniversal.Abrir();
                    string consulta = "Select * from Usuarios where id_usuario = '" + textBBuscar_usuario.Text + "'";
                    SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                    SqlDataReader leer = comando.ExecuteReader();
                    while (leer.Read())
                    {
                        Obj_Usuario.codrol = leer[0].ToString();
                        Obj_Usuario.NumDocumento = leer[1].ToString();
                        Obj_Usuario.Usuario = leer[2].ToString();
                        Obj_Usuario.Contrasena = leer[3].ToString();
                        Obj_Usuario.Nombre = leer[4].ToString();
                        Obj_Usuario.Telefono = leer[5].ToString();
                        Obj_Usuario.Correo = leer[6].ToString();
                    }
                    CLASES.Cslquniversal.Cerrar();
                }
                else
                {
                    MessageBox.Show("ingresa documento de identidad para buscar");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
           
            if (Obj_Usuario.codrol=="1")
            {
                radBAdmin.Checked = true;
            }
            else
            {
                radBvendedor.Checked = true;
            }
            texbID_Usuario.Text = Obj_Usuario.NumDocumento;
            texbNew_usuario.Text = Obj_Usuario.Usuario;
            texbcontrasena.Text = Obj_Usuario.Contrasena;
            texbconfirmar.Text = Obj_Usuario.Contrasena;
            texbNombre.Text = Obj_Usuario.Nombre;
            texbTelefono.Text = Obj_Usuario.Telefono;
            texbCorreo.Text = Obj_Usuario.Correo;
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            int comprobar = 0;
            if (texbID_Usuario.Text == "" || texbNombre.Text == "" || texbNew_usuario.Text == "" || texbCorreo.Text == "" || texbTelefono.Text == "" || texbcontrasena.Text == "" || texbconfirmar.Text == "" || radBAdmin.Checked == false && radBvendedor.Checked == false)
            {
                MessageBox.Show("Los Campos Marcados Con * Son Obligatorios");
            }
            else
            {
                if (texbcontrasena.Text != texbconfirmar.Text)
                {
                    MessageBox.Show("las contraseñas no coinciden");
                }
                else
                {
                    if (texbCorreo.Text.IndexOf('@') < 0)
                    {
                        MessageBox.Show("Correo electronico con formato incorrecto");
                    }
                    else
                    {
                        if (int.TryParse(texbTelefono.Text, out comprobar))
                        {
                            agrego();
                        }
                        else
                        {
                            MessageBox.Show("El Numero telefonico con formato incorrecto");
                        }
                    }
                }
            }

        }

        public void agrego()
        {
            string id = Obj_Usuario.NumDocumento;
            if (texbcontrasena.Text==texbconfirmar.Text)
            {
                Obj_Usuario.NumDocumento = texbID_Usuario.Text;
                Obj_Usuario.Usuario = texbNew_usuario.Text;
                Obj_Usuario.Contrasena = texbcontrasena.Text;
                Obj_Usuario.Nombre = texbNombre.Text;
                Obj_Usuario.Telefono = texbTelefono.Text;
                Obj_Usuario.Correo = texbCorreo.Text;
                if (radBAdmin.Checked == true)
                {
                    Obj_Usuario.codrol = "1";
                }
                else
                {
                    Obj_Usuario.codrol = "2";
                }

                try
                {

                    CLASES.Cslquniversal.Abrir();
                    string consulta = $"update Usuarios  set codigo_rol=@p1,id_usuario=@p2,usuario=@p3,clave=@p4,nombre_usuario=@p5,telefono=@p6,correo=@p7  WHERE id_usuario='{id}'  ";
                    SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                    comando.Parameters.AddWithValue("p1",Obj_Usuario.codrol);
                    comando.Parameters.AddWithValue("p2", Obj_Usuario.NumDocumento);
                    comando.Parameters.AddWithValue("p3", Obj_Usuario.Usuario);
                    comando.Parameters.AddWithValue("p4", Obj_Usuario.Contrasena);
                    comando.Parameters.AddWithValue("p5", Obj_Usuario.Usuario);
                    comando.Parameters.AddWithValue("p6", Obj_Usuario.Telefono);
                    comando.Parameters.AddWithValue("p7", Obj_Usuario.Correo);
                    comando.ExecuteNonQuery();
                    CLASES.Cslquniversal.Cerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CLASES.Cslquniversal.Cerrar();
                }
            }
            else
            {
                MessageBox.Show("las contraseñas no coinciden ");
            }
            MessageBox.Show("datos actualizados");
            limpiar();
        }
        public void limpiar()
        {
            texbconfirmar.Clear();
            texbcontrasena.Clear();
            texbCorreo.Clear();
            texbNew_usuario.Clear();
            texbNombre.Clear();
            texbTelefono.Clear();
            textBBuscar_usuario.Clear();
            texbID_Usuario.Clear();
            radBAdmin.Checked = false;
            radBvendedor.Checked = false;
        }

        private void FormNew_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
