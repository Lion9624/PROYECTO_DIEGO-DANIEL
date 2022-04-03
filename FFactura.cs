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
using System.IO;
using System.Drawing.Printing;

namespace Proyecto_Programacion
{
    public partial class FFactura : Form
    {

        //SqlConnection conn = new SqlConnection("server=DIEGO123\\SQLEXPRESS; database=Licorera1.0; integrated security= true ");
        CLASES.CProductos ObjProductos_f = new CLASES.CProductos();
        CLASES.CCliente Obj_Cliente_F = new CLASES.CCliente();
        CLASES.CFactura Obj_Factura = new CLASES.CFactura();
        CLASES.CDetalle_Factura Obj_Detalle = new CLASES.CDetalle_Factura();
        int i = 1, can = 0, Num_F=0;
        double sub_total = 0, total = 0;
        ListViewItem lista = new ListViewItem();
        public FFactura()
        {
            InitializeComponent();
            texBTotal_Factura.Enabled = false;
            texBCambio_Factura.Enabled = false;
            num_factura();


        }
        public void num_factura()
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta1 = ("select count (*) Numero_Factura from Factura");
                SqlCommand comando1 = new SqlCommand(consulta1, CLASES.Cslquniversal.conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                SqlDataReader leer = comando1.ExecuteReader();
                while (leer.Read())
                {
                    Num_F = Convert.ToInt32(leer[0].ToString());
                }
                CLASES.Cslquniversal.Cerrar();
                Num_F++;
                labNUMFACTURA_F.Text = Num_F.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            
        }

        private void texBDireccionClien_F_TextChanged(object sender, EventArgs e)
        {

        }

        private void butProducto_F_Click(object sender, EventArgs e)
        {
            panelDataProducto_F.Visible =true;
            Leer();
            
        }

        private void dataGridViewProducto_F_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow filas = this.dataGridViewProducto_F.Rows[e.RowIndex];
                try
                {
                    ObjProductos_f.CodigoP = filas.Cells[0].Value.ToString();
                    ObjProductos_f.NombreP = filas.Cells[1].Value.ToString();
                    ObjProductos_f.PrecioC = Convert.ToDouble(filas.Cells[2].Value.ToString());
                    ObjProductos_f.PrecioV = Convert.ToDouble(filas.Cells[3].Value.ToString());
                    ObjProductos_f.Cantidad = Convert.ToInt32(filas.Cells[4].Value.ToString());


                }
                catch (Exception)
                {

                    MessageBox.Show(" SELECCIONASTE CAMPOS VACIOS ");
                }




            }
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
                dataGridViewProducto_F.DataSource = resultado;
                CLASES.Cslquniversal.Cerrar(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }

        }

        private void butFILTRO_Click(object sender, EventArgs e)
        {
           
        }
        public void limpiar_Pro()
        {
            ObjProductos_f.CodigoP = "";

        }
        private void butAgregarPro_F_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = 0;
                if (ObjProductos_f.CodigoP!="")
                {
                    CLASES.Cslquniversal.Abrir();
                    string consulta =$"SELECT cantidad FROM Productos where Cod_Producto='{ObjProductos_f.CodigoP}'";
                    SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    SqlDataReader leer = comando.ExecuteReader();
                    while (leer.Read())
                    {
                        cantidad = Convert.ToInt32(leer[0].ToString());
                    }
                    CLASES.Cslquniversal.Cerrar();
                    if (cantidad<0)
                    {
                        MessageBox.Show("EL producto seleccionado no tiene stock");
                        texBCantidadPro_F.Clear();
                    }
                    else
                    {
                        if (cantidad<Convert.ToInt32(texBCantidadPro_F.Text))
                        {
                            MessageBox.Show("la cantidad ingresada es mayor que el stock");
                            texBCantidadPro_F.Clear();
                        }
                        else
                        {
                            can = Convert.ToInt32(texBCantidadPro_F.Text);
                            sub_total = can * ObjProductos_f.PrecioV;
                            total = total + sub_total;
                            //ListViewItem lista = new ListViewItem(i.ToString());
                            lista = new ListViewItem(i.ToString());
                            lista.SubItems.Add(ObjProductos_f.CodigoP);
                            lista.SubItems.Add(ObjProductos_f.NombreP);
                            lista.SubItems.Add(Convert.ToString(can));
                            lista.SubItems.Add(Convert.ToString(ObjProductos_f.PrecioV));
                            lista.SubItems.Add(sub_total.ToString());
                            i++;
                            listViewFACTURA_F.Items.AddRange(new ListViewItem[] { lista });

                            limpiar();
                            texB();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Selecciona un producto", "MENSAJE DE ALERTA ", MessageBoxButtons.OK);
                }
                limpiar_Pro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("ingrese un valor numerico");              
            }


        }
        public void actualizar()
        {
            try
            {
                int ojalaf = 1;
                for (int j = 0; j < listViewFACTURA_F.Items.Count; j++)
                {
                    listViewFACTURA_F.Items[j].Text = ojalaf.ToString();
                    //MessageBox.Show(ojalaf.ToString());
                    ojalaf++;
                    //MessageBox.Show(lista.Text);
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex} ERROR", "MENSAJE DE ERROR", MessageBoxButtons.OK);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem Producto in listViewFACTURA_F.SelectedItems)
                {
                    Producto.Remove();
                    string prueba =Producto.SubItems[5].Text;                   
                    total = total - Convert.ToDouble(prueba);
                    texB();                
                    i--;
                   
                }
                actualizar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void butFILTRO_Click_1(object sender, EventArgs e)
        {
            ObjProductos_f.NombreP = texBFiltro_F.Text;
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta = $"SELECT* FROM Productos WHERE Nombre LIKE '%{ObjProductos_f.NombreP}%'";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                dataGridViewProducto_F.DataSource = resultado;
                CLASES.Cslquniversal.Cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }
        }

        private void butBuscarPro_F_Click(object sender, EventArgs e)
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta = "Select * from cliente where Cedula_cliente = '" + texBBuscarUser_F.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.SelectCommand = comando;
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                SqlDataReader leer = comando.ExecuteReader();
                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("el usuario no se encuntra registrado");
                    limpiar();
                }
                else
                {
                    while (leer.Read())
                    {
                        Obj_Cliente_F.Cedula_C = leer[0].ToString();
                        Obj_Cliente_F.Nombre_C = leer[1].ToString();
                        Obj_Cliente_F.Telefono_C = leer[2].ToString();
                        Obj_Cliente_F.Correo_C = leer[3].ToString();
                        Obj_Cliente_F.Dir_C = leer[4].ToString();

                        texBIdentificacionCliente_F.Text = Obj_Cliente_F.Cedula_C;
                        texBNombreCliente_F.Text = Obj_Cliente_F.Nombre_C;
                        texBTelCliente_F.Text = Obj_Cliente_F.Telefono_C;
                        texBCorreoCliente_F.Text = Obj_Cliente_F.Correo_C;
                        texBDireccionClien_F.Text = Obj_Cliente_F.Dir_C;
                    }
                }
                CLASES.Cslquniversal.Cerrar();
                texBBuscarUser_F.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex} ERROR", "MENSAJE DE ERROR", MessageBoxButtons.OK);
                //MessageBox.Show( EX.Message, "MENSAJE DE ERROR" , MessageBoxButtons.OK);
                CLASES.Cslquniversal.Cerrar();

            }

        }

        private void butRegistro_Cliente_F_Click(object sender, EventArgs e)
        {
            Obj_Cliente_F.Cedula_C = texBIdentificacionCliente_F.Text;
            Obj_Cliente_F.Nombre_C = texBNombreCliente_F.Text;
            Obj_Cliente_F.Telefono_C = texBTelCliente_F.Text;
            Obj_Cliente_F.Correo_C = texBCorreoCliente_F.Text;
            Obj_Cliente_F.Dir_C = texBDireccionClien_F.Text;

            Agregar();
        }

        public void limpiar()
        {
            texBCantidadPro_F.Clear();
            texBFiltro_F.Clear();
            texBIdentificacionCliente_F.Clear();
            texBNombreCliente_F.Clear();
            texBTelCliente_F.Clear();
            texBCorreoCliente_F.Clear();
            texBDireccionClien_F.Clear();            
        }

        private void butActualizar_F_Click(object sender, EventArgs e)
        {
            if (texBIdentificacionCliente_F.Text!="")
            {
                agrago();
            }
            else
            {
                MessageBox.Show("debes llenar los campos ");
            }            
        }
        public void agrago()
        {
            string id = Obj_Cliente_F.Cedula_C;
            Obj_Cliente_F.Cedula_C = texBIdentificacionCliente_F.Text;
            Obj_Cliente_F.Nombre_C = texBNombreCliente_F.Text;
            Obj_Cliente_F.Telefono_C = texBTelCliente_F.Text;
            Obj_Cliente_F.Correo_C = texBCorreoCliente_F.Text;
            Obj_Cliente_F.Dir_C = texBDireccionClien_F.Text;     

                try
                {
                CLASES.Cslquniversal.Abrir();
                string consulta = $"update cliente  set Cedula_cliente=@p1,Nombres=@p2,Telefono=@p3,Email=@p4,Direccion=@p5  WHERE Cedula_cliente='{id}'  ";
                    SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                    comando.Parameters.AddWithValue("p1", Obj_Cliente_F.Cedula_C);
                    comando.Parameters.AddWithValue("p2", Obj_Cliente_F.Nombre_C);
                    comando.Parameters.AddWithValue("p3", Obj_Cliente_F.Telefono_C);
                    comando.Parameters.AddWithValue("p4", Obj_Cliente_F.Correo_C);
                    comando.Parameters.AddWithValue("p5", Obj_Cliente_F.Dir_C);
                    comando.ExecuteNonQuery();
                    CLASES.Cslquniversal.Cerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CLASES.Cslquniversal.Cerrar();
                }
            MessageBox.Show("datos actualizados");            
        }

        private void texBCambio_Factura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void texBEfectivo_Factura_TextChanged(object sender, EventArgs e)
        {
            try
            {                
                if (texBEfectivo_Factura.Text!="")
                {
                    texBCambio_Factura.Text = Convert.ToString(Convert.ToInt32(texBEfectivo_Factura.Text) - total);
                }
                else
                {
                    texBCambio_Factura.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
        }

        private void texBDescuento_Factura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void butPagar_Factura_Click(object sender, EventArgs e)
        {
            try
            {
                if (texBIdentificacionCliente_F.Text !="") 
                {
                    if (texBEfectivo_Factura.Text!="")
                    {
                        if (Convert.ToInt32(texBEfectivo_Factura.Text) >= Convert.ToInt32(texBTotal_Factura.Text))
                        {
                            Obj_Factura.Num_Factura = Num_F.ToString();
                            Obj_Factura.Fecha = DateTime.Now.ToString();
                            Obj_Factura.Total_F = total.ToString();
                            Obj_Factura.Cod_User = CLASES.C_Usuario.NumDocumento;
                            Obj_Factura.Cedula_Cliente = Obj_Cliente_F.Cedula_C;

                            Agregar_Factura();
                            for (int i = 0; i < listViewFACTURA_F.Items.Count; i++)
                            {
                                Obj_Detalle.Num_Factura_D = Num_F.ToString();
                                Obj_Detalle.Cod_Prod_D = listViewFACTURA_F.Items[i].SubItems[1].Text;
                                Obj_Detalle.Cantidad_D = listViewFACTURA_F.Items[i].SubItems[3].Text;
                                Obj_Detalle.Valor_Und = listViewFACTURA_F.Items[i].SubItems[4].Text;
                                Agregar_Detalle();
                                Act_Producto();

                            }
                            Imprimir = new PrintDocument();
                            PrinterSettings set = new PrinterSettings();
                            Imprimir.PrinterSettings = set;
                            Imprimir.PrintPage += Imprimir_PrintPage;
                            Imprimir.Print();
                            Num_F++;
                            limpiar();
                            limpiar2();
                            num_factura();
                            panelDataProducto_F.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Valor ingresado incorrecto ", "MENSAJE DE ALERTA ", MessageBoxButtons.OK);
                        }                       
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Monto dado", "MENSAJE DE ALERTA ", MessageBoxButtons.OK);
                    }                   
                }
                else
                {
                    MessageBox.Show("Ingrese la Informacion del cliente ","MENSAJE DE ALERTA ",MessageBoxButtons.OK);
                }               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                CLASES.Cslquniversal.Cerrar();
            }           

        }

        private void Imprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("arial", 12);
            int ancho = 400;
            int Y = 20;
            e.Graphics.DrawString("-------------- Punto de venta --------------", fuente, Brushes.Black, new RectangleF(0, Y += 20, ancho, 20));
            e.Graphics.DrawString("--------------  LicoTapetusa  --------------", fuente, Brushes.Black, new RectangleF(0, Y += 20, ancho, 20));
            e.Graphics.DrawString("-------------- Nit: 669696969 --------------", fuente, Brushes.Black, new RectangleF(0, Y += 20, ancho, 20));
            e.Graphics.DrawString("------------ Calle 55 # 81 sur -------------", fuente, Brushes.Black, new RectangleF(0, Y += 20, ancho, 20));
            e.Graphics.DrawString("-------------- Tel: 555-89-43 --------------", fuente, Brushes.Black, new RectangleF(0, Y += 20, ancho, 20));
            e.Graphics.DrawString($"--------------# Factura: {labNUMFACTURA_F.Text} --------------", fuente, Brushes.Black, new RectangleF(0, Y += 20, ancho, 20));
            e.Graphics.DrawString("------------ Detalle Factura: --------------", fuente, Brushes.Black, new RectangleF(0, Y += 50, ancho, 20));
            
            for (int i = 0; i < listViewFACTURA_F.Items.Count; i++)
            {
                string variable1 = listViewFACTURA_F.Items[i].SubItems[2].Text;
                string variable2 = listViewFACTURA_F.Items[i].SubItems[3].Text;
                string variable3 = listViewFACTURA_F.Items[i].SubItems[5].Text;
                e.Graphics.DrawString($"{i + 1}"+ " | " + $"{variable1}" + " | " + 
                    $"{variable2}" + " | " + 
                    $"{variable3}"
                    , fuente, Brushes.Black, new RectangleF(0, Y += 20, ancho, 20));

            }
            e.Graphics.DrawString($"------------- Total: {total} -----------", fuente, Brushes.Black, new RectangleF(0, Y += 50, ancho, 20));
            e.Graphics.DrawString($"--------------Efectivo: {texBEfectivo_Factura.Text}  --------------", fuente, Brushes.Black, new RectangleF(0, Y += 20, ancho, 20));
            e.Graphics.DrawString($"-------------- Cambio: {texBCambio_Factura.Text}  --------------", fuente, Brushes.Black, new RectangleF(0, Y += 20, ancho, 20));
            e.Graphics.DrawString("---------- Gracias por su compra -----------", fuente, Brushes.Black, new RectangleF(0, Y += 50, ancho, 20));
        }

        private void ImprimirFactura()
        {
            
        }

        private void texBTotal_Factura_TextChanged(object sender, EventArgs e)
        {

        }

        public void texB()
        {
            texBTotal_Factura.Text = total.ToString();
        }
        public void Agregar()
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta1 = "Insert into cliente values (@p1, @p2, @p3, @p4, @p5)";
                SqlCommand comando1 = new SqlCommand(consulta1, CLASES.Cslquniversal.conn);
                comando1.Parameters.AddWithValue("p1", Convert.ToInt32(Obj_Cliente_F.Cedula_C));
                comando1.Parameters.AddWithValue("p2", Obj_Cliente_F.Nombre_C);
                comando1.Parameters.AddWithValue("p3", Convert.ToInt32(Obj_Cliente_F.Telefono_C));
                comando1.Parameters.AddWithValue("p4", Obj_Cliente_F.Correo_C);
                comando1.Parameters.AddWithValue("p5", Obj_Cliente_F.Dir_C);

                comando1.ExecuteNonQuery();
                CLASES.Cslquniversal.Cerrar();
                MessageBox.Show("usuario agregado");
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void Agregar_Factura()
        {
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta1 = "Insert into Factura values (@p1, @p2, @p3, @p4, @p5)";
                SqlCommand comando1 = new SqlCommand(consulta1, CLASES.Cslquniversal.conn);
                comando1.Parameters.AddWithValue("p1", Convert.ToInt32(Obj_Factura.Num_Factura));
                comando1.Parameters.AddWithValue("p2",Convert.ToDateTime( Obj_Factura.Fecha));
                comando1.Parameters.AddWithValue("p3", Convert.ToDouble(Obj_Factura.Total_F));
                comando1.Parameters.AddWithValue("p4",Convert.ToInt32( Obj_Factura.Cod_User));
                comando1.Parameters.AddWithValue("p5",Convert.ToInt32( Obj_Factura.Cedula_Cliente));
                comando1.ExecuteNonQuery();
                CLASES.Cslquniversal.Cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FFactura_Load(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_F_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }

        public void Agregar_Detalle()
        {            
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta1 = "Insert into Detalle_Factura values (@p1, @p2, @p3, @p4)";
                SqlCommand comando1 = new SqlCommand(consulta1, CLASES.Cslquniversal.conn);
                comando1.Parameters.AddWithValue("p1", Convert.ToInt32(Obj_Detalle.Num_Factura_D));
                comando1.Parameters.AddWithValue("p2", Obj_Detalle.Cod_Prod_D);
                comando1.Parameters.AddWithValue("p3", Convert.ToInt32( Obj_Detalle.Cantidad_D));
                comando1.Parameters.AddWithValue("p4", Convert.ToDouble(Obj_Detalle.Valor_Und));
                comando1.ExecuteNonQuery();
                CLASES.Cslquniversal.Cerrar();
            }
            catch (Exception ex)
            {
                CLASES.Cslquniversal.Cerrar();
                MessageBox.Show(ex.Message);
            }
        }
        public void limpiar2()
        {
            texBTotal_Factura.Clear();
            texBEfectivo_Factura.Clear();
            texBCambio_Factura.Clear();
            listViewFACTURA_F.Items.Clear();
            Obj_Cliente_F.Cedula_C = "";
            Obj_Cliente_F.Correo_C = "";
            Obj_Cliente_F.Dir_C = "";
            Obj_Cliente_F.Nombre_C = "";
            Obj_Cliente_F.Telefono_C = "";
            total = 0;
        }
        public void Act_Producto()
        {
            int can = 0;
            try
            {
                CLASES.Cslquniversal.Abrir();
                string consulta1 = $"SELECT cantidad FROM Productos WHERE Cod_Producto = '{Obj_Detalle.Cod_Prod_D}'";
                SqlCommand comando1 = new SqlCommand(consulta1, CLASES.Cslquniversal.conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();             
                SqlDataReader leer = comando1.ExecuteReader();
                while (leer.Read())
                {
                    can =Convert.ToInt32( leer[0].ToString());                   
                }
                CLASES.Cslquniversal.Cerrar();

                ObjProductos_f.Cantidad = Convert.ToInt32(can - Convert.ToInt32(Obj_Detalle.Cantidad_D));

                CLASES.Cslquniversal.Abrir();
                string consulta = $"update Productos set  cantidad= @p1 where Cod_Producto = '{Obj_Detalle.Cod_Prod_D}'";
                SqlCommand comando = new SqlCommand(consulta, CLASES.Cslquniversal.conn);
                comando.Parameters.AddWithValue("p1", ObjProductos_f.Cantidad);
                comando.ExecuteNonQuery();
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
