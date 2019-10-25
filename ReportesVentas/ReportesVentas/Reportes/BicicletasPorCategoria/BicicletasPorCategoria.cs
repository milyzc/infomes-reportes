using Microsoft.Reporting.WinForms;
using ReportesVentas.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesVentas.Reportes
{
    public partial class BicicletasPorCategoria : Form
    {
        public BicicletasPorCategoria()
        {
            InitializeComponent();           
        }

        private void BicicletasPorCategoria_Load(object sender, EventArgs e)
        {
            this.RwBicisPorCategoria.RefreshReport();
            CantBicisPorCategoriaDSTableAdapters.categoriasTableAdapter adapter = new CantBicisPorCategoriaDSTableAdapters.categoriasTableAdapter();
            var data = new CantBicisPorCategoriaDS.categoriasDataTable();

            ////// obtengo datos a mostrar          
            adapter.Fill(data);

            ////// creo el parametro CantBicisPorCategoriaDS con el calor datos;
            var ds = new ReportDataSource("categorias", (DataTable) data);


            RwBicisPorCategoria.LocalReport.DataSources.Clear();

            ////// envio este parametro al reporte
            RwBicisPorCategoria.LocalReport.DataSources.Add(ds);

         this.RwBicisPorCategoria.RefreshReport();

        }
    }
}
