namespace ReportesVentas
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicicletasPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasVendidasUltimoMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasVendidasUltimoMesToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bicicletasPorCategoriaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // bicicletasPorCategoriaToolStripMenuItem
            // 
            this.bicicletasPorCategoriaToolStripMenuItem.Name = "bicicletasPorCategoriaToolStripMenuItem";
            this.bicicletasPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.bicicletasPorCategoriaToolStripMenuItem.Text = "Bicicletas por categoría";
            this.bicicletasPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.bicicletasPorCategoriaToolStripMenuItem_Click);
            // 
            // marcasVendidasUltimoMesToolStripMenuItem
            // 
            this.marcasVendidasUltimoMesToolStripMenuItem.Name = "marcasVendidasUltimoMesToolStripMenuItem";
            this.marcasVendidasUltimoMesToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.marcasVendidasUltimoMesToolStripMenuItem.Text = "Marcas vendidas ultimo mes";
            this.marcasVendidasUltimoMesToolStripMenuItem.Click += new System.EventHandler(this.marcasVendidasUltimoMesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 136);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informes y reportes";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Informes Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicicletasPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasVendidasUltimoMesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

