using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Programacion
{
    
    public partial class FormPantalla_principal : Form
    {
        //CLASES.C_Usuario Objeto_Usuario = new CLASES.C_Usuario();
        FormIngreso llamado;
        public FormPantalla_principal(/*FormIngreso.datos info*/)
        {
            
            InitializeComponent();
            label2.Text = CLASES.C_Usuario.Nombre;
            if (CLASES.C_Usuario.codrol == "2")
            {
                butNew_usuario.Enabled = false;
                butProvedores.Enabled = false;               
            }
        }
        private void abrirFormulario(System.Windows.Forms.Form formHijo)
        {
            //panelMenu.Width = 70; // disminuye el tamaño del menú y  solo muestra el icono
            //si el formulario / instancia no existe
            if (this.panelVentana.Controls.Count > 0)
                this.panelVentana.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelVentana.Controls.Add(formHijo);
            formHijo.Show();

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPantalla_principal_Load(object sender, EventArgs e)
        {

        }

        private void butNew_usuario_Click(object sender, EventArgs e)
        {

            FormNew_Usuario llamado_NEW_user = new FormNew_Usuario();
            abrirFormulario(llamado_NEW_user);
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butProvedores_Click(object sender, EventArgs e)
        {
            FProvedores llamado_lista_provedores = new FProvedores();
            abrirFormulario(llamado_lista_provedores);
        }

        private void butProductos_Click(object sender, EventArgs e)
        {

            FormPRODUCTOS llamado_lista_producto = new FormPRODUCTOS();
            abrirFormulario(llamado_lista_producto);
        }

        private void butVentas_Click(object sender, EventArgs e)
        {
            FFactura llamado_facturas = new FFactura();
            abrirFormulario(llamado_facturas);
        }

        private void ButReportes_Click(object sender, EventArgs e)
        {
            FReportes llamado_reporte=new FReportes();
            abrirFormulario(llamado_reporte);
        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            llamado = new FormIngreso();
            llamado.Show();
            this.Hide();
        }
    }
}
