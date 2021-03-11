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
    public partial class frm_bienvenida : Form
    {
        public frm_bienvenida()
        {
            
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enca_venta Enca_Venta = new Enca_venta();
            Enca_Venta.MdiParent = this.MdiParent;
            Enca_Venta.Show();
            this.Close();
        }

        private void frm_bienvenida_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            Enca_compra Enca_compra = new Enca_compra();
            Enca_compra.MdiParent = this.MdiParent;
            Enca_compra.Show();
            this.Close();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.MdiParent = this.MdiParent;
            productos.Show();
            this.Close();
        }

        private void btn_personas_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();
            personas.MdiParent = this.MdiParent;
            personas.Show();
            this.Close();
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {

        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.MdiParent = this.MdiParent;
            reportes.Show();
            this.Close();
        }
    }
}
