﻿using ReportesVentas.Informes.BicicletasVendidasUltimoMes;
using ReportesVentas.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesVentas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void bicicletasPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BicicletasPorCategoria();
            form.ShowDialog();
        }

        private void marcasVendidasUltimoMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Informes.ClientesPorCiudad.BicicletasVendidasUltimoMes();
            form.ShowDialog();
        }
    }
}
