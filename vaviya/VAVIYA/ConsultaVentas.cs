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
    public partial class ConsultaVentas : Form
    {
        EncVentaBL datos = new EncVentaBL();
        public ConsultaVentas()
        {
            InitializeComponent();
        }

        private void ConsultaVentas_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Dock = DockStyle.Fill;
                var dt = datos.ObtenerFacturas(textBox2.Text, textBox1.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[4].Width = 450;
            }
            catch
            {
                MessageBox.Show("Datos Vacios");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Dock = DockStyle.Fill;
                var dt = datos.ObtenerFacturas(textBox2.Text, textBox1.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[4].Width = 450;
            }
            catch
            {
                MessageBox.Show("Datos Vacios");
            }

        }
    }
}
