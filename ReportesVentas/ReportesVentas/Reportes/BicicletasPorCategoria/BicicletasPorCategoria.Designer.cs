namespace ReportesVentas.Reportes
{
    partial class BicicletasPorCategoria
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
            this.RwBicisPorCategoria = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RwBicisPorCategoria
            // 
            this.RwBicisPorCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RwBicisPorCategoria.LocalReport.ReportEmbeddedResource = "ReportesVentas.Reportes.BicicletasPorCategoria.BicicletaPorCategoriaInforme.rdlc";
            this.RwBicisPorCategoria.Location = new System.Drawing.Point(0, 0);
            this.RwBicisPorCategoria.Name = "RwBicisPorCategoria";
            this.RwBicisPorCategoria.ServerReport.BearerToken = null;
            this.RwBicisPorCategoria.Size = new System.Drawing.Size(800, 450);
            this.RwBicisPorCategoria.TabIndex = 0;
            // 
            // BicicletasPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RwBicisPorCategoria);
            this.Name = "BicicletasPorCategoria";
            this.Text = "BicicletasPorCategoria";
            this.Load += new System.EventHandler(this.BicicletasPorCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwBicisPorCategoria;
    }
}