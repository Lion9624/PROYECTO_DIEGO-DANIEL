
namespace Proyecto_Programacion
{
    partial class FProvedores
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
            System.Windows.Forms.Button butBuscar_prov;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProvedores));
            this.labBUSCAR = new System.Windows.Forms.Label();
            this.dataGridView_Provedores = new System.Windows.Forms.DataGridView();
            this.texBBuscar_prov = new System.Windows.Forms.TextBox();
            this.butAgregar_prov = new System.Windows.Forms.Button();
            this.butModificar_prov = new System.Windows.Forms.Button();
            this.butEliminar_prov = new System.Windows.Forms.Button();
            this.butSalir_prov = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butActualizar = new System.Windows.Forms.Button();
            this.texBCorreo_Prov = new System.Windows.Forms.TextBox();
            this.texBDireccion_prov = new System.Windows.Forms.TextBox();
            this.texBtelefono_prov = new System.Windows.Forms.TextBox();
            this.texBNombre_prov = new System.Windows.Forms.TextBox();
            this.texBNit_prov = new System.Windows.Forms.TextBox();
            this.labCorreo_pro = new System.Windows.Forms.Label();
            this.labDireccion_pro = new System.Windows.Forms.Label();
            this.labTelefono_pro = new System.Windows.Forms.Label();
            this.labNombre_Pro = new System.Windows.Forms.Label();
            this.labNit_PRO = new System.Windows.Forms.Label();
            butBuscar_prov = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Provedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butBuscar_prov
            // 
            butBuscar_prov.Image = ((System.Drawing.Image)(resources.GetObject("butBuscar_prov.Image")));
            butBuscar_prov.Location = new System.Drawing.Point(488, 7);
            butBuscar_prov.Name = "butBuscar_prov";
            butBuscar_prov.Size = new System.Drawing.Size(30, 23);
            butBuscar_prov.TabIndex = 2;
            butBuscar_prov.UseVisualStyleBackColor = true;
            butBuscar_prov.Click += new System.EventHandler(this.butBuscar_prov_Click);
            // 
            // labBUSCAR
            // 
            this.labBUSCAR.AutoSize = true;
            this.labBUSCAR.BackColor = System.Drawing.Color.Silver;
            this.labBUSCAR.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBUSCAR.Location = new System.Drawing.Point(91, 9);
            this.labBUSCAR.Name = "labBUSCAR";
            this.labBUSCAR.Size = new System.Drawing.Size(61, 17);
            this.labBUSCAR.TabIndex = 18;
            this.labBUSCAR.Text = "Buscar:";
            // 
            // dataGridView_Provedores
            // 
            this.dataGridView_Provedores.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_Provedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Provedores.GridColor = System.Drawing.Color.White;
            this.dataGridView_Provedores.Location = new System.Drawing.Point(16, 36);
            this.dataGridView_Provedores.Name = "dataGridView_Provedores";
            this.dataGridView_Provedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Provedores.Size = new System.Drawing.Size(580, 338);
            this.dataGridView_Provedores.TabIndex = 3;
            this.dataGridView_Provedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Provedores_CellClick);
            this.dataGridView_Provedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Provedores_CellContentClick);
            // 
            // texBBuscar_prov
            // 
            this.texBBuscar_prov.Location = new System.Drawing.Point(227, 9);
            this.texBBuscar_prov.Name = "texBBuscar_prov";
            this.texBBuscar_prov.Size = new System.Drawing.Size(186, 20);
            this.texBBuscar_prov.TabIndex = 1;
            // 
            // butAgregar_prov
            // 
            this.butAgregar_prov.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAgregar_prov.Location = new System.Drawing.Point(43, 475);
            this.butAgregar_prov.Name = "butAgregar_prov";
            this.butAgregar_prov.Size = new System.Drawing.Size(87, 31);
            this.butAgregar_prov.TabIndex = 10;
            this.butAgregar_prov.Text = "Agregar";
            this.butAgregar_prov.UseVisualStyleBackColor = true;
            this.butAgregar_prov.Click += new System.EventHandler(this.butAgregar_prov_Click);
            // 
            // butModificar_prov
            // 
            this.butModificar_prov.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butModificar_prov.Location = new System.Drawing.Point(185, 475);
            this.butModificar_prov.Name = "butModificar_prov";
            this.butModificar_prov.Size = new System.Drawing.Size(87, 31);
            this.butModificar_prov.TabIndex = 11;
            this.butModificar_prov.Text = "Modificar";
            this.butModificar_prov.UseVisualStyleBackColor = true;
            this.butModificar_prov.Click += new System.EventHandler(this.butModificar_prov_Click);
            // 
            // butEliminar_prov
            // 
            this.butEliminar_prov.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminar_prov.Location = new System.Drawing.Point(327, 475);
            this.butEliminar_prov.Name = "butEliminar_prov";
            this.butEliminar_prov.Size = new System.Drawing.Size(87, 31);
            this.butEliminar_prov.TabIndex = 12;
            this.butEliminar_prov.Text = "ELiminar";
            this.butEliminar_prov.UseVisualStyleBackColor = true;
            this.butEliminar_prov.Click += new System.EventHandler(this.butEliminar_prov_Click);
            // 
            // butSalir_prov
            // 
            this.butSalir_prov.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalir_prov.Location = new System.Drawing.Point(469, 475);
            this.butSalir_prov.Name = "butSalir_prov";
            this.butSalir_prov.Size = new System.Drawing.Size(87, 31);
            this.butSalir_prov.TabIndex = 13;
            this.butSalir_prov.Text = "Salir";
            this.butSalir_prov.UseVisualStyleBackColor = true;
            this.butSalir_prov.Click += new System.EventHandler(this.butSalir_prov_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.butActualizar);
            this.panel1.Controls.Add(this.texBCorreo_Prov);
            this.panel1.Controls.Add(this.texBDireccion_prov);
            this.panel1.Controls.Add(this.texBtelefono_prov);
            this.panel1.Controls.Add(this.texBNombre_prov);
            this.panel1.Controls.Add(this.texBNit_prov);
            this.panel1.Controls.Add(this.labCorreo_pro);
            this.panel1.Controls.Add(this.labDireccion_pro);
            this.panel1.Controls.Add(this.labTelefono_pro);
            this.panel1.Controls.Add(this.labNombre_Pro);
            this.panel1.Controls.Add(this.labNit_PRO);
            this.panel1.Location = new System.Drawing.Point(6, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 84);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // butActualizar
            // 
            this.butActualizar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butActualizar.Location = new System.Drawing.Point(253, 53);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(87, 28);
            this.butActualizar.TabIndex = 9;
            this.butActualizar.Text = "Guardar";
            this.butActualizar.UseVisualStyleBackColor = true;
            this.butActualizar.Click += new System.EventHandler(this.butActualizar_Click);
            // 
            // texBCorreo_Prov
            // 
            this.texBCorreo_Prov.Location = new System.Drawing.Point(483, 27);
            this.texBCorreo_Prov.Name = "texBCorreo_Prov";
            this.texBCorreo_Prov.Size = new System.Drawing.Size(104, 20);
            this.texBCorreo_Prov.TabIndex = 8;
            // 
            // texBDireccion_prov
            // 
            this.texBDireccion_prov.Location = new System.Drawing.Point(364, 27);
            this.texBDireccion_prov.Name = "texBDireccion_prov";
            this.texBDireccion_prov.Size = new System.Drawing.Size(104, 20);
            this.texBDireccion_prov.TabIndex = 7;
            // 
            // texBtelefono_prov
            // 
            this.texBtelefono_prov.Location = new System.Drawing.Point(245, 27);
            this.texBtelefono_prov.Name = "texBtelefono_prov";
            this.texBtelefono_prov.Size = new System.Drawing.Size(104, 20);
            this.texBtelefono_prov.TabIndex = 6;
            // 
            // texBNombre_prov
            // 
            this.texBNombre_prov.Location = new System.Drawing.Point(126, 27);
            this.texBNombre_prov.Name = "texBNombre_prov";
            this.texBNombre_prov.Size = new System.Drawing.Size(104, 20);
            this.texBNombre_prov.TabIndex = 5;
            // 
            // texBNit_prov
            // 
            this.texBNit_prov.Location = new System.Drawing.Point(7, 27);
            this.texBNit_prov.Name = "texBNit_prov";
            this.texBNit_prov.Size = new System.Drawing.Size(104, 20);
            this.texBNit_prov.TabIndex = 4;
            // 
            // labCorreo_pro
            // 
            this.labCorreo_pro.AutoSize = true;
            this.labCorreo_pro.BackColor = System.Drawing.Color.Silver;
            this.labCorreo_pro.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCorreo_pro.Location = new System.Drawing.Point(480, 7);
            this.labCorreo_pro.Name = "labCorreo_pro";
            this.labCorreo_pro.Size = new System.Drawing.Size(63, 17);
            this.labCorreo_pro.TabIndex = 22;
            this.labCorreo_pro.Text = "Correo :";
            // 
            // labDireccion_pro
            // 
            this.labDireccion_pro.AutoSize = true;
            this.labDireccion_pro.BackColor = System.Drawing.Color.Silver;
            this.labDireccion_pro.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDireccion_pro.Location = new System.Drawing.Point(361, 7);
            this.labDireccion_pro.Name = "labDireccion_pro";
            this.labDireccion_pro.Size = new System.Drawing.Size(86, 17);
            this.labDireccion_pro.TabIndex = 21;
            this.labDireccion_pro.Text = "Direccion :";
            // 
            // labTelefono_pro
            // 
            this.labTelefono_pro.AutoSize = true;
            this.labTelefono_pro.BackColor = System.Drawing.Color.Silver;
            this.labTelefono_pro.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono_pro.Location = new System.Drawing.Point(242, 7);
            this.labTelefono_pro.Name = "labTelefono_pro";
            this.labTelefono_pro.Size = new System.Drawing.Size(78, 17);
            this.labTelefono_pro.TabIndex = 20;
            this.labTelefono_pro.Text = "Telefono :";
            this.labTelefono_pro.Click += new System.EventHandler(this.labTelefono_pro_Click);
            // 
            // labNombre_Pro
            // 
            this.labNombre_Pro.AutoSize = true;
            this.labNombre_Pro.BackColor = System.Drawing.Color.Silver;
            this.labNombre_Pro.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre_Pro.Location = new System.Drawing.Point(123, 7);
            this.labNombre_Pro.Name = "labNombre_Pro";
            this.labNombre_Pro.Size = new System.Drawing.Size(70, 17);
            this.labNombre_Pro.TabIndex = 20;
            this.labNombre_Pro.Text = "Nombre :";
            // 
            // labNit_PRO
            // 
            this.labNit_PRO.AutoSize = true;
            this.labNit_PRO.BackColor = System.Drawing.Color.Silver;
            this.labNit_PRO.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNit_PRO.Location = new System.Drawing.Point(7, 7);
            this.labNit_PRO.Name = "labNit_PRO";
            this.labNit_PRO.Size = new System.Drawing.Size(40, 17);
            this.labNit_PRO.TabIndex = 19;
            this.labNit_PRO.Text = "Nit :";
            // 
            // FProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butSalir_prov);
            this.Controls.Add(this.butEliminar_prov);
            this.Controls.Add(this.butModificar_prov);
            this.Controls.Add(this.butAgregar_prov);
            this.Controls.Add(butBuscar_prov);
            this.Controls.Add(this.texBBuscar_prov);
            this.Controls.Add(this.dataGridView_Provedores);
            this.Controls.Add(this.labBUSCAR);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FProvedores";
            this.Text = "FProvedores";
            this.Load += new System.EventHandler(this.FProvedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Provedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBUSCAR;
        private System.Windows.Forms.DataGridView dataGridView_Provedores;
        private System.Windows.Forms.TextBox texBBuscar_prov;
        private System.Windows.Forms.Button butAgregar_prov;
        private System.Windows.Forms.Button butModificar_prov;
        private System.Windows.Forms.Button butEliminar_prov;
        private System.Windows.Forms.Button butSalir_prov;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox texBCorreo_Prov;
        private System.Windows.Forms.TextBox texBDireccion_prov;
        private System.Windows.Forms.TextBox texBtelefono_prov;
        private System.Windows.Forms.TextBox texBNombre_prov;
        private System.Windows.Forms.TextBox texBNit_prov;
        private System.Windows.Forms.Label labCorreo_pro;
        private System.Windows.Forms.Label labDireccion_pro;
        private System.Windows.Forms.Label labTelefono_pro;
        private System.Windows.Forms.Label labNombre_Pro;
        private System.Windows.Forms.Label labNit_PRO;
        private System.Windows.Forms.Button butActualizar;
    }
}