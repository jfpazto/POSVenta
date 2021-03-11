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
    public partial class FProductos : Form
    {
        ProductoBL prod = new ProductoBL();
        public FProductos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            var dt = prod.ObtenerProductosInv(textBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Width = 400;
            
            //MessageBox.Show("Hola Mundo");
        }

        private void FProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportarDatos(dataGridView1);
        }
        public void exportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();
            exportar.Application.Workbooks.Add(true);
            int indicecolumna = 0;
            foreach (DataGridViewColumn columna in datalistado.Columns)
            {
                indicecolumna++;
                exportar.Cells[1, indicecolumna] = columna.Name;
            }
            int indicefila = 0;
            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                indicefila++;
                indicecolumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indicecolumna++;
                    exportar.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportar.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            var dt = prod.ObtenerProductosCod(textBox2.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Width = 400;
        }
    }
}
