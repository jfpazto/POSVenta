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

namespace VAVIYA
{
    public partial class FactVenta : Form
    {
        public List<Datos> datos = new List<Datos>();
        public List<Datos> datos1 = new List<Datos>();
        public List<Datos> datos2 = new List<Datos>();
        public List<Datos> datos3 = new List<Datos>();
        public List<Datos> datos4 = new List<Datos>();
        public FactVenta()
        {
            InitializeComponent();
        }
        private void FactVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Vaviya12DataSet1.otro_factura' Puede moverla o quitarla según sea necesario.
            this.otro_facturaTableAdapter.Fill(this.Vaviya12DataSet1.otro_factura);
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", datos));
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", datos1));
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", datos2));
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet4", datos3));
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet5", datos4));

            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
