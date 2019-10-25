using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;


namespace ReportesVentas.Informes.ClientesPorCiudad
{
    public partial class BicicletasVendidasUltimoMes : Form
    {
        public BicicletasVendidasUltimoMes()
        {
            InitializeComponent();
        }

        private void BicicletasVendidasUltimoMes_Load(object sender, EventArgs e)
        {
            this.RwBicicletas.RefreshReport();
            Informes.BicicletasVendidasUltimoMes.BicicletasVendidasUltimoMesTableAdapters.marcasTableAdapter adapter 
                = new Informes.BicicletasVendidasUltimoMes.BicicletasVendidasUltimoMesTableAdapters.marcasTableAdapter();
            var data = new Informes.BicicletasVendidasUltimoMes.BicicletasVendidasUltimoMes.marcasDataTable();

            ////// obtengo datos a mostrar          
            adapter.Fill(data);

            ////// creo el parametro CantBicisPorCategoriaDS con el calor datos;
            var ds = new ReportDataSource("bicicletasDS", (DataTable) data);


            RwBicicletas.LocalReport.DataSources.Clear();

            ////// envio este parametro al reporte
            RwBicicletas.LocalReport.DataSources.Add(ds);

            this.RwBicicletas.RefreshReport();
        }
    }
}
