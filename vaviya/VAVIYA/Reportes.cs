using BusinessLayer;
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
    public partial class Reportes : Form
    {
        ReportesBL reportes_info = new ReportesBL();
        public Reportes()
        {
            InitializeComponent();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            dataVencer.Visible = true;
            var dt = reportes_info.ObtenerProductos();

            dataVencer.DataSource = dt;
            dataVencer.Columns[2].DefaultCellStyle.BackColor = Color.Salmon;
            dataVencer.Columns[0].Width = 250;
            dataVencer.Columns[1].Width = 550;
            dataVencer.Columns[2].Width = 100;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            dataVencer.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void Busca_venta_Click(object sender, EventArgs e)
        {
            string Fecha_ini = System.Convert.ToString(date_desde.Value.Date.ToString("yyyy/MM/dd"));
            string Fecha_fin = System.Convert.ToString(date_hasta.Value.Date.ToString("yyyy/MM/dd"));
            var dt = reportes_info.Consulta_fecha(Fecha_ini,Fecha_fin);
            data_fec_venta.DataSource = dt;

            int i;
            int suma = 0;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                suma = suma + System.Convert.ToInt32(data_fec_venta.Rows[i].Cells["EncVentaValorTotal"].Value.ToString());
            }
            
            label2.Text= suma.ToString();
            label_tot_ventas.Text = i.ToString();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void VentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void But_busca_compra_Click(object sender, EventArgs e)
        {
            
            string Fecha_ini = System.Convert.ToString(fec_ini_compra.Value.Date.ToString("yyyy/MM/dd"));
            string Fecha_fin = System.Convert.ToString(fec_fin_compra.Value.Date.ToString("yyyy/MM/dd"));
            var dt = reportes_info.Consulta_compra_fecha(Fecha_ini, Fecha_fin);
            data_fec_compra.DataSource = dt;

            int i;
            int suma = 0;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                suma = suma + System.Convert.ToInt32(data_fec_compra.Rows[i].Cells["EncCompValorTotal"].Value.ToString());
            }

            label_total_compras.Text = suma.ToString();
            label_num_compras.Text = i.ToString();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }

        private void Bt_home_Click(object sender, EventArgs e)
        {
            frm_bienvenida bienve = new frm_bienvenida();
            bienve.MdiParent = this.MdiParent;
            bienve.Show();
            this.Close();
        }

        private void fec_fin_compra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void consultarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProductos invProductos = new FProductos();
            invProductos.Show();
        }

        private void consultarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaVentas invProductos = new ConsultaVentas();
            invProductos.Show();
        }

        private void contabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contabilidad frmContabilidad = new Contabilidad();
            frmContabilidad.Show();
        }
    }
}
