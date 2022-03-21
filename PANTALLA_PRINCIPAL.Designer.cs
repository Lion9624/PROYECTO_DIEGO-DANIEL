
namespace Proyecto_Programacion
{
    partial class FormPantalla_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPantalla_principal));
            this.panelBotones = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butNew_usuario = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.butProductos = new System.Windows.Forms.Button();
            this.butProvedores = new System.Windows.Forms.Button();
            this.butVentas = new System.Windows.Forms.Button();
            this.panelVentana = new System.Windows.Forms.Panel();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBotones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBotones.Controls.Add(this.label2);
            this.panelBotones.Controls.Add(this.label1);
            this.panelBotones.Controls.Add(this.labNombre);
            this.panelBotones.Controls.Add(this.panel1);
            this.panelBotones.Controls.Add(this.butNew_usuario);
            this.panelBotones.Controls.Add(this.butSalir);
            this.panelBotones.Controls.Add(this.butProductos);
            this.panelBotones.Controls.Add(this.butProvedores);
            this.panelBotones.Controls.Add(this.butVentas);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(166, 583);
            this.panelBotones.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "BIENVENIDO:";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(12, 112);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(0, 14);
            this.labNombre.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 82);
            this.panel1.TabIndex = 6;
            // 
            // butNew_usuario
            // 
            this.butNew_usuario.BackColor = System.Drawing.Color.Gray;
            this.butNew_usuario.FlatAppearance.BorderSize = 0;
            this.butNew_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNew_usuario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNew_usuario.Image = ((System.Drawing.Image)(resources.GetObject("butNew_usuario.Image")));
            this.butNew_usuario.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.butNew_usuario.Location = new System.Drawing.Point(12, 291);
            this.butNew_usuario.Name = "butNew_usuario";
            this.butNew_usuario.Size = new System.Drawing.Size(137, 55);
            this.butNew_usuario.TabIndex = 3;
            this.butNew_usuario.Text = "Usuario";
            this.butNew_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butNew_usuario.UseVisualStyleBackColor = false;
            this.butNew_usuario.Click += new System.EventHandler(this.butNew_usuario_Click);
            // 
            // butSalir
            // 
            this.butSalir.BackColor = System.Drawing.Color.Gray;
            this.butSalir.FlatAppearance.BorderSize = 0;
            this.butSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalir.Image = ((System.Drawing.Image)(resources.GetObject("butSalir.Image")));
            this.butSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSalir.Location = new System.Drawing.Point(12, 437);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(137, 55);
            this.butSalir.TabIndex = 5;
            this.butSalir.Text = "SALIR";
            this.butSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSalir.UseVisualStyleBackColor = false;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // butProductos
            // 
            this.butProductos.BackColor = System.Drawing.Color.Gray;
            this.butProductos.FlatAppearance.BorderSize = 0;
            this.butProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butProductos.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butProductos.Image = ((System.Drawing.Image)(resources.GetObject("butProductos.Image")));
            this.butProductos.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.butProductos.Location = new System.Drawing.Point(12, 218);
            this.butProductos.Name = "butProductos";
            this.butProductos.Size = new System.Drawing.Size(137, 55);
            this.butProductos.TabIndex = 2;
            this.butProductos.Text = "PRODUCTOS";
            this.butProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butProductos.UseVisualStyleBackColor = false;
            this.butProductos.Click += new System.EventHandler(this.butProductos_Click);
            // 
            // butProvedores
            // 
            this.butProvedores.BackColor = System.Drawing.Color.Gray;
            this.butProvedores.FlatAppearance.BorderSize = 0;
            this.butProvedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butProvedores.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butProvedores.Image = ((System.Drawing.Image)(resources.GetObject("butProvedores.Image")));
            this.butProvedores.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.butProvedores.Location = new System.Drawing.Point(12, 364);
            this.butProvedores.Name = "butProvedores";
            this.butProvedores.Size = new System.Drawing.Size(137, 55);
            this.butProvedores.TabIndex = 4;
            this.butProvedores.Text = "PROVEDOR";
            this.butProvedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butProvedores.UseVisualStyleBackColor = false;
            this.butProvedores.Click += new System.EventHandler(this.butProvedores_Click);
            // 
            // butVentas
            // 
            this.butVentas.BackColor = System.Drawing.Color.Gray;
            this.butVentas.FlatAppearance.BorderSize = 0;
            this.butVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVentas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVentas.Image = ((System.Drawing.Image)(resources.GetObject("butVentas.Image")));
            this.butVentas.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.butVentas.Location = new System.Drawing.Point(12, 145);
            this.butVentas.Name = "butVentas";
            this.butVentas.Size = new System.Drawing.Size(137, 55);
            this.butVentas.TabIndex = 1;
            this.butVentas.Text = "VENTAS";
            this.butVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butVentas.UseVisualStyleBackColor = false;
            this.butVentas.Click += new System.EventHandler(this.butVentas_Click);
            // 
            // panelVentana
            // 
            this.panelVentana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelVentana.BackgroundImage")));
            this.panelVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVentana.Location = new System.Drawing.Point(166, 0);
            this.panelVentana.Name = "panelVentana";
            this.panelVentana.Size = new System.Drawing.Size(847, 583);
            this.panelVentana.TabIndex = 0;
            // 
            // FormPantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1013, 583);
            this.Controls.Add(this.panelVentana);
            this.Controls.Add(this.panelBotones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPantalla_principal";
            this.Text = "PANTALLA _PRINCIPAL";
            this.Load += new System.EventHandler(this.FormPantalla_principal_Load);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.Button butProductos;
        private System.Windows.Forms.Button butProvedores;
        private System.Windows.Forms.Panel panelVentana;
        private System.Windows.Forms.Button butVentas;
        private System.Windows.Forms.Button butNew_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}