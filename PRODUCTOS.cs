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
    public partial class FormPRODUCTOS : Form
    {
        //SqlConnection conn = new SqlConnection("server=DIEGO123\\SQLEXPRESS; database=Licorera1.0; integrated security= true ");
        CLASES.CProductos ObjProductos = new CLASES.CProductos();
        public FormPRODUCTOS()
        {
            InitializeComponent();
            try
            {
                Leer();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            if (CLASES.C_Usuario.codrol == "2")
            {
                butAgregar.Enabled = false;
                butEliminar.Enabled = false;
                butModificar.Enabled = false;
                texBCodigo_Producto.Enabled = false;
                texBNombre_Producto.Enabled = false;
                texBPrecio_Compra.Enabled = false;
                texBPrecio_Venta.Enabled = false;
                textBCantidad.Enabled = false;
            }
        }

        private void FormPRODUCTOS_Load(object sender, EventArgs e)
        {

        }

        public void Leer()
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta = "SELECT * FROM Productos";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                dataGridVProductos.DataSource = resultado;
                CLASES.Cslquniversal.Cerrar();
            }
            catch (Exception  ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
     
        }
        public void Agregar()
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta = "INSERT INTO Productos VALUES (@p1,@p2,@p3,@p4,@p5)";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                comando.Parameters.AddWithValue("p1", ObjProductos.CodigoP);
                comando.Parameters.AddWithValue("p2", ObjProductos.NombreP);
                comando.Parameters.AddWithValue("p3",ObjProductos.PrecioC);
                comando.Parameters.AddWithValue("p4",ObjProductos.PrecioV);
                comando.Parameters.AddWithValue("p5", ObjProductos.Cantidad);
                comando.ExecuteNonQuery();
                CLASES.Cslquniversal.Cerrar();
                limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
           


            Leer();
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            int P1;          
            if (texBCodigo_Producto.Text != "" && texBNombre_Producto.Text != ""&& textBCantidad.Text!=""&& texBPrecio_Venta.Text!=""&& texBPrecio_Compra.Text!="")
            {
                if (int.TryParse(textBCantidad.Text, out P1)&& int.TryParse(texBPrecio_Venta.Text, out P1)&& int.TryParse(texBPrecio_Compra.Text, out P1))
                {
                    ObjProductos.CodigoP = texBCodigo_Producto.Text;
                    ObjProductos.NombreP = texBNombre_Producto.Text;
                    ObjProductos.PrecioC = Convert.ToDouble(texBPrecio_Compra.Text);
                    ObjProductos.PrecioV = Convert.ToDouble(texBPrecio_Venta.Text);
                    ObjProductos.Cantidad = Convert.ToInt32(textBCantidad.Text);

                    Agregar();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Debes ingresar valores numericos", "MENSAJE ALERTA", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos","MENSAJE ALERTA",MessageBoxButtons.OK);
            }

        }

        private void dataGridVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
               
                DataGridViewRow filas = this.dataGridVProductos.Rows[e.RowIndex];
                try
                {
                    ObjProductos.CodigoP = filas.Cells[0].Value.ToString();
                    ObjProductos.NombreP = filas.Cells[1].Value.ToString();
                    ObjProductos.PrecioC = Convert.ToDouble(filas.Cells[2].Value.ToString());
                    ObjProductos.PrecioV = Convert.ToDouble(filas.Cells[3].Value.ToString());
                    ObjProductos.Cantidad = Convert.ToInt32(filas.Cells[4].Value.ToString());

                    texBCodigo_Producto.Text = ObjProductos.CodigoP;
                    texBNombre_Producto.Text = ObjProductos.NombreP;
                    texBPrecio_Compra.Text = Convert.ToString(ObjProductos.PrecioC);
                    texBPrecio_Venta.Text = Convert.ToString(ObjProductos.PrecioV);
                    textBCantidad.Text = Convert.ToString(ObjProductos.Cantidad);
                }
                catch (Exception )
                {

                    MessageBox.Show(" SELECCIONASTE CAMPOS VACIOS ");
                }




            }

        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            int P1;
            if (ObjProductos.CodigoP!="" && texBCodigo_Producto.Text!="" && texBNombre_Producto.Text != "" && textBCantidad.Text != "" && texBPrecio_Venta.Text != "" && texBPrecio_Compra.Text != "")
            {
                if (int.TryParse(textBCantidad.Text, out P1) && int.TryParse(texBPrecio_Venta.Text, out P1) && int.TryParse(texBPrecio_Compra.Text, out P1))
                {
                    if (MessageBox.Show("Realizar los cambios","CONFIRMAR",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {

                        String dato = ObjProductos.CodigoP;
                        ObjProductos.CodigoP = texBCodigo_Producto.Text;
                        ObjProductos.NombreP = texBNombre_Producto.Text;
                        ObjProductos.PrecioC = Convert.ToDouble(texBPrecio_Compra.Text);
                        ObjProductos.PrecioV = Convert.ToDouble(texBPrecio_Venta.Text);
                        ObjProductos.Cantidad = Convert.ToInt32(textBCantidad.Text);

                        Modificar(dato);

                    }

                }
                else
                {
                   MessageBox.Show("Debes ingresar valores numericos", "MENSAJE ALERTA", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos", "MENSAJE ALERTA", MessageBoxButtons.OK);
            }

            Leer();

        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿SEguro Deseas Eliminar Este Producto ?", "CONFIRMAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Eliminar();
            }
            
        }
        public void Modificar(string P1)
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta = $"update  Productos set Cod_Producto=@p1, Nombre=@p2,Precio_Compra=@p3,Precio_venta=@p4,cantidad=@p5 where Cod_Producto = '{P1}'";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                comando.Parameters.AddWithValue("p1", ObjProductos.CodigoP);
                comando.Parameters.AddWithValue("p2", ObjProductos.NombreP);
                comando.Parameters.AddWithValue("p3", ObjProductos.PrecioC);
                comando.Parameters.AddWithValue("p4", ObjProductos.PrecioV);
                comando.Parameters.AddWithValue("p5", ObjProductos.Cantidad);
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
                String dato = ObjProductos.CodigoP;
                CLASES.Cslquniversal.Abrir();
                string consulta = $"DELETE FROM Productos WHERE Cod_Producto = @P1;";
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
            texBCodigo_Producto.Clear();
            texBNombre_Producto.Clear();
            texBPrecio_Compra.Clear();
            texBPrecio_Venta.Clear();
            textBCantidad.Clear();
       
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            ObjProductos.NombreP = texBBuscar.Text;
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta =$"SELECT* FROM Productos WHERE Nombre LIKE '%{ObjProductos.NombreP}%'";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                dataGridVProductos.DataSource = resultado;
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
