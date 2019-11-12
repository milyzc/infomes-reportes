namespace ReportesVentas.Informes.ClientesPorCiudad
{
    partial class BicicletasVendidasUltimoMes
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
            this.RwBicicletas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RwBicicletas
            // 
            this.RwBicicletas.LocalReport.ReportEmbeddedResource = "ReportesVentas.Informes.BicicletasVendidasUltimoMes.BicicletasVendidasUltimoMesI." +
    "rdlc";
            this.RwBicicletas.Location = new System.Drawing.Point(0, 44);
            this.RwBicicletas.Name = "RwBicicletas";
            this.RwBicicletas.ServerReport.BearerToken = null;
            this.RwBicicletas.Size = new System.Drawing.Size(800, 406);
            this.RwBicicletas.TabIndex = 0;
            // 
            // DTPFecha
            // 
            this.DTPFecha.CustomFormat = "MM/yyyy";
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFecha.Location = new System.Drawing.Point(124, 8);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(200, 22);
            this.DTPFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes / fecha";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(358, 8);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BicicletasVendidasUltimoMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.RwBicicletas);
            this.Name = "BicicletasVendidasUltimoMes";
            this.Text = "BicicletasVendidasUltimoMes";
            this.Load += new System.EventHandler(this.BicicletasVendidasUltimoMes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwBicicletas;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConsultar;
    }
}