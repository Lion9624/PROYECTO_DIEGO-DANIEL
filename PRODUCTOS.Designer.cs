
namespace Proyecto_Programacion
{
    partial class FormPRODUCTOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPRODUCTOS));
            this.labBuscar = new System.Windows.Forms.Label();
            this.labCodigo = new System.Windows.Forms.Label();
            this.labNombre_Prodcuto = new System.Windows.Forms.Label();
            this.labPrecio_compra = new System.Windows.Forms.Label();
            this.labPrecio_Venta = new System.Windows.Forms.Label();
            this.texBBuscar = new System.Windows.Forms.TextBox();
            this.texBCodigo_Producto = new System.Windows.Forms.TextBox();
            this.texBNombre_Producto = new System.Windows.Forms.TextBox();
            this.texBPrecio_Compra = new System.Windows.Forms.TextBox();
            this.texBPrecio_Venta = new System.Windows.Forms.TextBox();
            this.dataGridVProductos = new System.Windows.Forms.DataGridView();
            this.butBuscar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // labBuscar
            // 
            this.labBuscar.AutoSize = true;
            this.labBuscar.BackColor = System.Drawing.Color.Silver;
            this.labBuscar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labBuscar.Location = new System.Drawing.Point(12, 11);
            this.labBuscar.Name = "labBuscar";
            this.labBuscar.Size = new System.Drawing.Size(59, 15);
            this.labBuscar.TabIndex = 0;
            this.labBuscar.Text = "Buscar :";
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.BackColor = System.Drawing.Color.Silver;
            this.labCodigo.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labCodigo.Location = new System.Drawing.Point(12, 68);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(67, 15);
            this.labCodigo.TabIndex = 1;
            this.labCodigo.Text = "Codigo_P";
            // 
            // labNombre_Prodcuto
            // 
            this.labNombre_Prodcuto.AutoSize = true;
            this.labNombre_Prodcuto.BackColor = System.Drawing.Color.Silver;
            this.labNombre_Prodcuto.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre_Prodcuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labNombre_Prodcuto.Location = new System.Drawing.Point(126, 68);
            this.labNombre_Prodcuto.Name = "labNombre_Prodcuto";
            this.labNombre_Prodcuto.Size = new System.Drawing.Size(73, 15);
            this.labNombre_Prodcuto.TabIndex = 2;
            this.labNombre_Prodcuto.Text = "Nombre_P";
            // 
            // labPrecio_compra
            // 
            this.labPrecio_compra.AutoSize = true;
            this.labPrecio_compra.BackColor = System.Drawing.Color.Silver;
            this.labPrecio_compra.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrecio_compra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPrecio_compra.Location = new System.Drawing.Point(378, 68);
            this.labPrecio_compra.Name = "labPrecio_compra";
            this.labPrecio_compra.Size = new System.Drawing.Size(102, 15);
            this.labPrecio_compra.TabIndex = 3;
            this.labPrecio_compra.Text = "Precio_Compra";
            // 
            // labPrecio_Venta
            // 
            this.labPrecio_Venta.AutoSize = true;
            this.labPrecio_Venta.BackColor = System.Drawing.Color.Silver;
            this.labPrecio_Venta.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrecio_Venta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPrecio_Venta.Location = new System.Drawing.Point(510, 68);
            this.labPrecio_Venta.Name = "labPrecio_Venta";
            this.labPrecio_Venta.Size = new System.Drawing.Size(89, 15);
            this.labPrecio_Venta.TabIndex = 4;
            this.labPrecio_Venta.Text = "Precio_venta";
            // 
            // texBBuscar
            // 
            this.texBBuscar.Location = new System.Drawing.Point(77, 9);
            this.texBBuscar.Name = "texBBuscar";
            this.texBBuscar.Size = new System.Drawing.Size(425, 20);
            this.texBBuscar.TabIndex = 1;
            // 
            // texBCodigo_Producto
            // 
            this.texBCodigo_Producto.Location = new System.Drawing.Point(15, 97);
            this.texBCodigo_Producto.Name = "texBCodigo_Producto";
            this.texBCodigo_Producto.Size = new System.Drawing.Size(87, 20);
            this.texBCodigo_Producto.TabIndex = 3;
            // 
            // texBNombre_Producto
            // 
            this.texBNombre_Producto.Location = new System.Drawing.Point(129, 97);
            this.texBNombre_Producto.Name = "texBNombre_Producto";
            this.texBNombre_Producto.Size = new System.Drawing.Size(99, 20);
            this.texBNombre_Producto.TabIndex = 4;
            // 
            // texBPrecio_Compra
            // 
            this.texBPrecio_Compra.Location = new System.Drawing.Point(381, 97);
            this.texBPrecio_Compra.Name = "texBPrecio_Compra";
            this.texBPrecio_Compra.Size = new System.Drawing.Size(99, 20);
            this.texBPrecio_Compra.TabIndex = 6;
            // 
            // texBPrecio_Venta
            // 
            this.texBPrecio_Venta.Location = new System.Drawing.Point(507, 97);
            this.texBPrecio_Venta.Name = "texBPrecio_Venta";
            this.texBPrecio_Venta.Size = new System.Drawing.Size(107, 20);
            this.texBPrecio_Venta.TabIndex = 7;
            // 
            // dataGridVProductos
            // 
            this.dataGridVProductos.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVProductos.GridColor = System.Drawing.Color.White;
            this.dataGridVProductos.Location = new System.Drawing.Point(15, 138);
            this.dataGridVProductos.Name = "dataGridVProductos";
            this.dataGridVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVProductos.Size = new System.Drawing.Size(502, 376);
            this.dataGridVProductos.TabIndex = 12;
            this.dataGridVProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVProductos_CellClick);
            this.dataGridVProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVProductos_CellContentClick);
            // 
            // butBuscar
            // 
            this.butBuscar.Image = ((System.Drawing.Image)(resources.GetObject("butBuscar.Image")));
            this.butBuscar.Location = new System.Drawing.Point(508, 7);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(91, 22);
            this.butBuscar.TabIndex = 2;
            this.butBuscar.UseVisualStyleBackColor = true;
            this.butBuscar.Click += new System.EventHandler(this.butBuscar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAgregar.Location = new System.Drawing.Point(523, 138);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(91, 24);
            this.butAgregar.TabIndex = 8;
            this.butAgregar.Text = "AGREGAR";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butModificar.Location = new System.Drawing.Point(523, 248);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(91, 24);
            this.butModificar.TabIndex = 9;
            this.butModificar.Text = "MODIFICAR";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminar.Location = new System.Drawing.Point(523, 364);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(91, 24);
            this.butEliminar.TabIndex = 10;
            this.butEliminar.Text = "ELIMINAR";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butSalir
            // 
            this.butSalir.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalir.Location = new System.Drawing.Point(523, 490);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(91, 24);
            this.butSalir.TabIndex = 11;
            this.butSalir.Text = "SALIR";
            this.butSalir.UseVisualStyleBackColor = true;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(252, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad";
            // 
            // textBCantidad
            // 
            this.textBCantidad.Location = new System.Drawing.Point(255, 97);
            this.textBCantidad.Name = "textBCantidad";
            this.textBCantidad.Size = new System.Drawing.Size(99, 20);
            this.textBCantidad.TabIndex = 5;
            // 
            // FormPRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 538);
            this.Controls.Add(this.textBCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.butBuscar);
            this.Controls.Add(this.dataGridVProductos);
            this.Controls.Add(this.texBPrecio_Venta);
            this.Controls.Add(this.texBPrecio_Compra);
            this.Controls.Add(this.texBNombre_Producto);
            this.Controls.Add(this.texBCodigo_Producto);
            this.Controls.Add(this.texBBuscar);
            this.Controls.Add(this.labPrecio_Venta);
            this.Controls.Add(this.labPrecio_compra);
            this.Controls.Add(this.labNombre_Prodcuto);
            this.Controls.Add(this.labCodigo);
            this.Controls.Add(this.labBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPRODUCTOS";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.FormPRODUCTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBuscar;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.Label labNombre_Prodcuto;
        private System.Windows.Forms.Label labPrecio_compra;
        private System.Windows.Forms.Label labPrecio_Venta;
        private System.Windows.Forms.TextBox texBBuscar;
        private System.Windows.Forms.TextBox texBCodigo_Producto;
        private System.Windows.Forms.TextBox texBNombre_Producto;
        private System.Windows.Forms.TextBox texBPrecio_Compra;
        private System.Windows.Forms.TextBox texBPrecio_Venta;
        private System.Windows.Forms.DataGridView dataGridVProductos;
        private System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBCantidad;
    }
}