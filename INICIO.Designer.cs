
namespace Proyecto_Programacion
{
    partial class FormIngreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            this.labUsuario = new System.Windows.Forms.Label();
            this.labClave = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butIngresar = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labUsuario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsuario.ForeColor = System.Drawing.Color.Cyan;
            this.labUsuario.Location = new System.Drawing.Point(88, 131);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(76, 18);
            this.labUsuario.TabIndex = 0;
            this.labUsuario.Text = "Usuario :";
            // 
            // labClave
            // 
            this.labClave.AutoSize = true;
            this.labClave.BackColor = System.Drawing.Color.Transparent;
            this.labClave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClave.ForeColor = System.Drawing.Color.Cyan;
            this.labClave.Location = new System.Drawing.Point(103, 172);
            this.labClave.Name = "labClave";
            this.labClave.Size = new System.Drawing.Size(61, 18);
            this.labClave.TabIndex = 1;
            this.labClave.Text = "clave  :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(170, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(170, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 3;
            // 
            // butIngresar
            // 
            this.butIngresar.BackColor = System.Drawing.Color.Gray;
            this.butIngresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.butIngresar.FlatAppearance.BorderSize = 0;
            this.butIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIngresar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIngresar.ForeColor = System.Drawing.Color.Cyan;
            this.butIngresar.Location = new System.Drawing.Point(91, 272);
            this.butIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.butIngresar.Name = "butIngresar";
            this.butIngresar.Size = new System.Drawing.Size(73, 31);
            this.butIngresar.TabIndex = 4;
            this.butIngresar.Text = "Ingresar";
            this.butIngresar.UseVisualStyleBackColor = false;
            this.butIngresar.Click += new System.EventHandler(this.butIngresar_Click);
            // 
            // butSalir
            // 
            this.butSalir.BackColor = System.Drawing.Color.Gray;
            this.butSalir.FlatAppearance.BorderSize = 0;
            this.butSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalir.ForeColor = System.Drawing.Color.Cyan;
            this.butSalir.Location = new System.Drawing.Point(198, 272);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(80, 31);
            this.butSalir.TabIndex = 5;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = false;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 362);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butIngresar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labClave);
            this.Controls.Add(this.labUsuario);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormIngreso";
            this.Text = "INGRESO";
            this.Load += new System.EventHandler(this.FormIngreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.Label labClave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butIngresar;
        private System.Windows.Forms.Button butSalir;
    }
}

