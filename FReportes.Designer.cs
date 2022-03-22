namespace Proyecto_Programacion
{
    partial class FReportes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HASTA = new System.Windows.Forms.Label();
            this.dateTimeFIN = new System.Windows.Forms.DateTimePicker();
            this.dateTimeINICIO = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.DataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.HASTA);
            this.panel1.Controls.Add(this.dateTimeFIN);
            this.panel1.Controls.Add(this.dateTimeINICIO);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.DataGridViewReporte);
            this.panel1.Controls.Add(this.lblFiltrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 562);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HASTA
            // 
            this.HASTA.AutoSize = true;
            this.HASTA.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HASTA.Location = new System.Drawing.Point(190, 50);
            this.HASTA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HASTA.Name = "HASTA";
            this.HASTA.Size = new System.Drawing.Size(46, 15);
            this.HASTA.TabIndex = 18;
            this.HASTA.Text = "HASTA";
            // 
            // dateTimeFIN
            // 
            this.dateTimeFIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFIN.Location = new System.Drawing.Point(270, 50);
            this.dateTimeFIN.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFIN.Name = "dateTimeFIN";
            this.dateTimeFIN.Size = new System.Drawing.Size(151, 20);
            this.dateTimeFIN.TabIndex = 17;
            // 
            // dateTimeINICIO
            // 
            this.dateTimeINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeINICIO.Location = new System.Drawing.Point(11, 47);
            this.dateTimeINICIO.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeINICIO.Name = "dateTimeINICIO";
            this.dateTimeINICIO.Size = new System.Drawing.Size(151, 20);
            this.dateTimeINICIO.TabIndex = 16;
            this.dateTimeINICIO.Value = new System.DateTime(2022, 3, 21, 21, 41, 31, 0);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(448, 50);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 19);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OKAY";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DataGridViewReporte
            // 
            this.DataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewReporte.Location = new System.Drawing.Point(14, 89);
            this.DataGridViewReporte.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewReporte.Name = "DataGridViewReporte";
            this.DataGridViewReporte.RowHeadersWidth = 51;
            this.DataGridViewReporte.RowTemplate.Height = 24;
            this.DataGridViewReporte.Size = new System.Drawing.Size(681, 462);
            this.DataGridViewReporte.TabIndex = 14;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.BackColor = System.Drawing.Color.Maroon;
            this.lblFiltrar.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltrar.Location = new System.Drawing.Point(11, 9);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(65, 15);
            this.lblFiltrar.TabIndex = 13;
            this.lblFiltrar.Text = "FILTRAR";
            // 
            // FReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 562);
            this.Controls.Add(this.panel1);
            this.Name = "FReportes";
            this.Text = "FReportes";
            this.Load += new System.EventHandler(this.FReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HASTA;
        private System.Windows.Forms.DateTimePicker dateTimeFIN;
        private System.Windows.Forms.DateTimePicker dateTimeINICIO;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView DataGridViewReporte;
        private System.Windows.Forms.Label lblFiltrar;
    }
}