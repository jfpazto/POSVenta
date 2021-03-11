using BusinessLayer;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;

namespace VAVIYA
{
    public partial class Productos : Form

    {
        ProductoBL prodcutoBL = new ProductoBL();
        public Productos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void exportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();
            exportar.Application.Workbooks.Add(true);
            int indicecolumna =0;
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

        

        private void Productos_Load(object sender, EventArgs e)
        {
            
            this.Dock = DockStyle.Fill;
            var dt = prodcutoBL.ObtenerProductosInv("");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Width = 400;
            eliminar.BackColor = Color.Beige;
            cb_iva.Items.Add("0%");
            cb_iva.Items.Add("5%");
            cb_iva.Items.Add("19%");
            cb_iva.SelectedIndex = 2;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text != "" && txt_nombre.Text != "" && txt_precio.Text != "" && txt_costo.Text != "")
            {
                int iva = 0;
                float precio = System.Convert.ToSingle(txt_precio.Text);
                float costo = System.Convert.ToSingle(txt_costo.Text);
                
                float precio_sinIva=0;
                if (cb_iva.SelectedIndex == 0)
                {
                    iva = 0;
                    double op = precio / 1.00;
                    precio_sinIva = (float)op;

                }
                else if (cb_iva.SelectedIndex == 1)
                {
                    iva = 5;
                    double op = precio / 1.05;
                    precio_sinIva = (float)op;
                }
                else if (cb_iva.SelectedIndex == 2)
                {
                    iva = 19;
                    double op = precio / 1.19;
                    precio_sinIva =(float)op;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un dato para el iva");
                }

                
                prodcutoBL.Insertar_Productos_llama(txt_cod.Text, txt_nombre.Text, precio, costo,iva,precio_sinIva);
                string message = "Datos Registrados!!";
                string title = "VAVIYA";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                var dt = prodcutoBL.ObtenerProductos();
                dataGridView1.DataSource = dt;
                txt_cod.Text = "";
                txt_nombre.Text = "";
                txt_precio.Text = "";
                txt_costo.Text = "";
                cb_iva.Text = "";
                Productos Enca_Venta = new Productos();
                Enca_Venta.MdiParent = this.MdiParent;
                Enca_Venta.Show();
            }
            else
            {
                string message = "Hay campos vacios. Verifique";
                string title = "VAVIYA";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cuenta = dataGridView1.Rows.Count;
            if (cuenta != 1) 
            {
                int res = dataGridView1.Rows.Count - 2;
                dataGridView1.Rows[res].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, res];
                txt_cod.Text = dataGridView1.Rows[res].Cells[1].Value.ToString();
                txt_nombre.Text = dataGridView1.Rows[res].Cells[2].Value.ToString();
                txt_precio.Text = dataGridView1.Rows[res].Cells[3].Value.ToString();
                txt_costo.Text = dataGridView1.Rows[res].Cells[4].Value.ToString();
            }

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res = dataGridView1.Rows.Count;
            dataGridView1.Rows[0].Selected=true;
            dataGridView1.CurrentCell = dataGridView1[0,0];
            txt_cod.Text=dataGridView1.Rows[0].Cells[1].Value.ToString();
            txt_nombre.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txt_precio.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            txt_costo.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int res = dataGridView1.Rows.Count;
            if (res!=1)
            {
                int indice = dataGridView1.CurrentCell.RowIndex;
                if (indice != res - 2)
                {

                    dataGridView1.Rows[indice + 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, indice + 1];
                    txt_cod.Text = dataGridView1.Rows[indice + 1].Cells[1].Value.ToString();
                    txt_nombre.Text = dataGridView1.Rows[indice + 1].Cells[2].Value.ToString();
                    txt_precio.Text = dataGridView1.Rows[indice + 1].Cells[3].Value.ToString();
                    txt_costo.Text = dataGridView1.Rows[indice + 1].Cells[4].Value.ToString();
                }
            }


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int res = dataGridView1.Rows.Count;
            if (res!=1)
            {
                int indice = dataGridView1.CurrentCell.RowIndex;
                if (indice != 0)
                {

                    dataGridView1.Rows[indice - 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, indice - 1];
                    txt_cod.Text = dataGridView1.Rows[indice - 1].Cells[1].Value.ToString();
                    txt_nombre.Text = dataGridView1.Rows[indice - 1].Cells[2].Value.ToString();
                    txt_precio.Text = dataGridView1.Rows[indice - 1].Cells[3].Value.ToString();
                    txt_costo.Text = dataGridView1.Rows[indice - 1].Cells[4].Value.ToString();

                }
            }

        }

        private void txt_cod_TextChanged(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            var dt = prodcutoBL.ObtenerProductosCod(txt_cod.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Width = 400;
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsLetter(e.KeyChar) permite cualquier caracter entre la a y la z tanto mayusculas como minusculas
            //IsWhiteSpace permite espacio en blanco.
            //'\b' permite poder eliminar caracteres con BackSpace

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_cod.Text = "";
            txt_nombre.Text = "";
            txt_precio.Text = "";
            txt_costo.Text = "";
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = dataGridView1.CurrentCell.RowIndex;
                string id = dataGridView1.Rows[indice].Cells[0].Value.ToString();
                prodcutoBL.LLama_eli_productos(System.Convert.ToInt32(id));
                var dt = prodcutoBL.ObtenerProductos();
                dataGridView1.DataSource = dt;
                txt_cod.Text = "";
                txt_nombre.Text = "";
                txt_precio.Text = "";
                txt_costo.Text = "";
            }
            catch
            {
                string message = "Datos Incorrectos. Verifique";
                string title = "VAVIYA";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                txt_cod.Text = "";
                txt_nombre.Text = "";
                txt_precio.Text = "";
                txt_costo.Text = "";
            }

        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txt_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsPunctuation(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void Productos_Move(object sender, EventArgs e)
        {
           
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            frm_bienvenida bienve = new frm_bienvenida();
            bienve.MdiParent = this.MdiParent;
            bienve.Show();
            this.Close();
        }

        private void eliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int indice = dataGridView1.CurrentCell.RowIndex;
                string id = dataGridView1.Rows[indice].Cells[0].Value.ToString();
                prodcutoBL.LLama_eli_productos(System.Convert.ToInt32(id));
                var dt = prodcutoBL.ObtenerProductos();
                dataGridView1.DataSource = dt;
                txt_cod.Text = "";
                txt_nombre.Text = "";
                txt_precio.Text = "";
                txt_costo.Text = "";
            }
            catch
            {
                string message = "Datos Incorrectos. Verifique";
                string title = "VAVIYA";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                txt_cod.Text = "";
                txt_nombre.Text = "";
                txt_precio.Text = "";
                txt_costo.Text = "";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            padre bienve = new padre();
            groupBox1.Location = new System.Drawing.Point(15, 18);
            dataGridView1.Location = new System.Drawing.Point(15, 436);
            //this.Size = new Size(500,this.Size.Height);
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void button_genera_Click(object sender, EventArgs e)
        {
            BarcodeWriter br = new BarcodeWriter() { Format = ZXing.BarcodeFormat.CODE_128 };
            pic.Image = br.Write(txt_nombre.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            printBarCode();
        }

        private void printBarCode()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog()==DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pic.Width, pic.Height);
            pic.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, pic.Width, pic.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();

        }

        private void cb_iva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cb_iva_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cb_iva.SelectedIndex == 0)
            //    {
            //        double precio = Math.Round(System.Convert.ToInt32(txt_precio.Text) * 1.00, 0);
            //        txt_precio.Text = System.Convert.ToString(precio);

            //    }
            //    else if (cb_iva.SelectedIndex == 1)
            //    {
            //        double precio = Math.Round(System.Convert.ToInt32(txt_precio.Text) * 1.05, 0);
            //        txt_precio.Text = System.Convert.ToString(precio);
            //    }
            //    else if (cb_iva.SelectedIndex == 2)
            //    {
            //        double precio = Math.Round(System.Convert.ToInt32(txt_precio.Text) * 1.19, 0);
            //        txt_precio.Text = System.Convert.ToString(precio);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Debe seleccionar un dato para el iva");
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("El campo Precio debe tener un valor numerico ");
            //}

        }

        private void button8_Click(object sender, EventArgs e)
        {
            exportarDatos(dataGridView1);
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //si se pulsa e el header el RowIndex sera menos a menos
            if (!(e.RowIndex > -1))
            {
                return;
            }
            txt_cod.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_nombre.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_precio.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_costo.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            var dt = prodcutoBL.ObtenerProductosInv(txt_nombre.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Width = 400;
        }
    }
}
