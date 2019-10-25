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

namespace ReportesPav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //categoriasTableAdapter
            this.RwSta.RefreshReport();
            var adapter = new DataSEmpleadoTableAdapters.categoriasTableAdapter();
            var d = new DataSEmpleado.categoriasDataTable();

            adapter.Fill(d);

            ////// creo el parametro CantBicisPorCategoriaDS con el calor datos;
            var ds = new ReportDataSource("datos", (DataTable) d);


            RwSta.LocalReport.DataSources.Clear();

            ////// envio este parametro al reporte
            RwSta.LocalReport.DataSources.Add(ds);

            this.RwSta.RefreshReport();
        }
    }
}
