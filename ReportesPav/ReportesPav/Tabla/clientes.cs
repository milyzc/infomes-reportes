using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesPav.Tabla
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            var adapter = new DataSet1TableAdapters.clientesTableAdapter();
            var d = new DataSet1.clientesDataTable();

            adapter.Fill(d);

            ////// creo el parametro CantBicisPorCategoriaDS con el calor datos;
            var ds = new ReportDataSource("clientes", (DataTable) d);


            reportViewer1.LocalReport.DataSources.Clear();

            ////// envio este parametro al reporte
            reportViewer1.LocalReport.DataSources.Add(ds);

            this.reportViewer1.RefreshReport();


            // TODO: This line of code loads data into the 'DataSet1.clientes' table. You can move, or remove it, as needed.
            //this.clientesTableAdapter.Fill(this.DataSet1.clientes);

            //this.reportViewer1.RefreshReport();
        }
    }
}
