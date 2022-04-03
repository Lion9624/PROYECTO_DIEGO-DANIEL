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
    public partial class FProvedores : Form
    {
        int prueba = 0;
        //SqlConnection conn = new SqlConnection("server=DIEGO123\\SQLEXPRESS; database=Licorera1.0; integrated security= true ");
        CLASES.CProvedor Obj_Provedore = new CLASES.CProvedor();
        public FProvedores()
        {
            InitializeComponent();
            try
            {

                Leer();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
        }
        public void Leer()
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta = "SELECT * FROM provedores";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                dataGridView_Provedores.DataSource = resultado;
                CLASES.Cslquniversal.Cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FProvedores_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_Provedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow filas = this.dataGridView_Provedores.Rows[e.RowIndex];
                try
                {
                    Obj_Provedore.Nit = filas.Cells[0].Value.ToString();
                    Obj_Provedore.Nombre = filas.Cells[1].Value.ToString();
                    Obj_Provedore.Telefono = filas.Cells[2].Value.ToString();
                    Obj_Provedore.Direccion = filas.Cells[3].Value.ToString();
                    Obj_Provedore.Correo = filas.Cells[4].Value.ToString();

                    texBNit_prov.Text = Obj_Provedore.Nit;
                    texBNombre_prov.Text = Obj_Provedore.Nombre;
                    texBtelefono_prov.Text = Obj_Provedore.Telefono;
                    texBDireccion_prov.Text = Obj_Provedore.Direccion;
                    texBCorreo_Prov.Text = Obj_Provedore.Correo;
                }
                catch (Exception)
                {

                    MessageBox.Show(" SELECCIONASTE CAMPOS VACIOS ");
                    CLASES.Cslquniversal.Cerrar();
                }
            }
        }

        private void butModificar_prov_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            prueba = 2;
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            
            int numero;
            try
            {
                if (texBNit_prov.Text == "" || texBNombre_prov.Text == "" || texBtelefono_prov.Text == "" || texBDireccion_prov.Text == "" || texBCorreo_Prov.Text == "")
                {
                    MessageBox.Show("Se deben llenar todos los campos");
                }
                else
                {
                    if (int.TryParse(texBNit_prov.Text, out numero))
                    {
                        if (texBCorreo_Prov.Text.IndexOf('@') < 0)
                        {
                            MessageBox.Show("El formato del correo es incorrecto");
                        }
                        else
                        {
                            if (int.TryParse(texBtelefono_prov.Text, out numero))
                            {
                                if (prueba == 1)
                                {
                                    obj_texb();
                                    Agregar();
                                }
                                else if (prueba == 2)
                                {
                                    if (Obj_Provedore.Nit != "")
                                    {
                                        int dato = Convert.ToInt32(Obj_Provedore.Nit);
                                        obj_texb();

                                        modificar(dato);


                                    }

                                    Leer();

                                }
                                panel1.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("El formato del numero telefonico es incorrecto");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El formato del NIT es incorrecto");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }

           
        }

        private void butSalir_prov_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAgregar_prov_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            prueba = 1;
        }
        public void Agregar()
        {

            try
            {

                CLASES.Cslquniversal.Abrir();
                string consulta = "INSERT INTO Provedores VALUES (@p1,@p2,@p3,@p4,@p5)";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                comando.Parameters.AddWithValue("p1", Convert.ToInt32(Obj_Provedore.Nit));
                comando.Parameters.AddWithValue("p2", Obj_Provedore.Nombre);
                comando.Parameters.AddWithValue("p3", Convert.ToInt32(Obj_Provedore.Telefono));
                comando.Parameters.AddWithValue("p4", Obj_Provedore.Direccion);
                comando.Parameters.AddWithValue("p5", Obj_Provedore.Correo);
                comando.ExecuteNonQuery();
                CLASES.Cslquniversal.Cerrar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
            Leer();
            limpiar();
        }
        public void modificar(int p1)
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta = $"update  Provedores set Nit=@p1, Nombre=@p2,Telefono=@p3,Direccion_P=@p4, Email_P=@P5 where Nit = {p1}";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                comando.Parameters.AddWithValue("p1",Convert.ToInt32( Obj_Provedore.Nit));
                comando.Parameters.AddWithValue("p2", Obj_Provedore.Nombre);
                comando.Parameters.AddWithValue("p3", Convert.ToInt32(Obj_Provedore.Telefono));
                comando.Parameters.AddWithValue("p4", Obj_Provedore.Direccion);
                comando.Parameters.AddWithValue("p5", Obj_Provedore.Correo);
                comando.ExecuteNonQuery();
                CLASES.Cslquniversal.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
            limpiar();
        }
        public void Eliminar()
        {
            try
            {
                int dato = Convert.ToInt32(Obj_Provedore.Nit);
                CLASES.Cslquniversal.Abrir();
                string consulta = $"DELETE FROM Provedores WHERE Nit = @P1;";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                comando.Parameters.AddWithValue("p1", dato);
                comando.ExecuteNonQuery();
                CLASES.Cslquniversal.Cerrar();
                Leer();
                limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
  
        }
        public void limpiar()  
        {
            texBBuscar_prov.Clear();
            texBNit_prov.Clear();
            texBNombre_prov.Clear();
            texBtelefono_prov.Clear();
            texBDireccion_prov.Clear();
            texBCorreo_Prov.Clear();
        }
        public void obj_texb()
        {
            Obj_Provedore.Nit = texBNit_prov.Text;
            Obj_Provedore.Nombre = texBNombre_prov.Text;
            Obj_Provedore.Telefono = texBtelefono_prov.Text;
            Obj_Provedore.Direccion = texBDireccion_prov.Text;
            Obj_Provedore.Correo = texBCorreo_Prov.Text;
        }
        private void butEliminar_prov_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void butBuscar_prov_Click(object sender, EventArgs e)
        {

            Obj_Provedore.Nit = texBBuscar_prov.Text;
            try
            {
                if (texBBuscar_prov.Text!="")
                {
                    CLASES.Cslquniversal.Abrir();
                    string consulta = $"SELECT* FROM Provedores WHERE Nit LIKE '%{Obj_Provedore.Nit}%'";
                    SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    dataGridView_Provedores.DataSource = resultado;
                    CLASES.Cslquniversal.Cerrar();
                }
                else
                {
                    MessageBox.Show("Debes ingresar el Nit para buscar");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
        }

        private void labTelefono_pro_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Provedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
