using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAVIYA
{
    public partial class Enca_compra : Form
    {

        EncCompraBL datos = new EncCompraBL();
        public Enca_compra()
        {
            InitializeComponent();
        }

        private void Enca_compra_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Now;
            string valor_re = datos.LLama_registro_compra(); ;
            cod_compra.Text = valor_re;
            DataTable dr;
            dr = datos.obtiene_nombres_persona("empleado");
            int i;
            for (i=0;i<dr.Rows.Count;i++)
            {
                
                comboBox1.Items.Add(dr.Rows[i][0].ToString() + " " + dr.Rows[i][1].ToString());
                lis_nom_em.Items.Add(dr.Rows[i][0].ToString());
                lis_ape_em.Items.Add(dr.Rows[i][1].ToString());
            }

            DataTable dl;
            dl = datos.obtiene_nombres_persona("proveedor");
            int j;
            for (j = 0; j < dl.Rows.Count; j++)
            {
             
                cb_proveedor.Items.Add(dl.Rows[j][0].ToString() + " " + dl.Rows[j][1].ToString());
                list_nombres.Items.Add(dl.Rows[j][0].ToString());
                list_apellidos.Items.Add(dl.Rows[j][1].ToString());
            }


            this.Dock = DockStyle.Fill;

            //establece el color de los headers del datagridview
            dataenca_compra.ColumnHeadersDefaultCellStyle.BackColor = Color.PaleGoldenrod;
            dataenca_compra.EnableHeadersVisualStyles = false;

            //dataenca_compra.Columns["Column1"].ReadOnly = true;
            dataenca_compra.Columns["Column4"].ReadOnly = true;
            dataenca_compra.Columns["Column5"].ReadOnly = true;
            

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void dataenca_compra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void dataenca_compra_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    MessageBox.Show(dataenca_compra.CurrentCell.Value.ToString());
        //}
 
        

        private void dataenca_compra_KeyDown(object sender, KeyEventArgs e)
        {
      
           


        }

        private void dataenca_compra_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txtProdid = e.Control as TextBox;
            TextBox txtProdidCod = e.Control as TextBox;
            SqlConnection conexion = new SqlConnection("Server=(localdb)\\Vaviya;DataBase=Vaviya12; integrated security= true");
            if (dataenca_compra.CurrentCell.ColumnIndex == 1)
            {
                SqlDataReader dreader;
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();
                cmd.CommandText = "Select ProdNombre From Productos";
                conexion.Open();
                dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                        autocom.Add(dreader["ProdNombre"].ToString());

                }
                else
                {
                    MessageBox.Show("ERROR");

                }
                dreader.Close();
                
                if (txtProdid != null) 
                {
                    txtProdid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtProdid.AutoCompleteCustomSource = autocom;
                    txtProdid.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                conexion.Close();
            }

            else if (dataenca_compra.CurrentCell.ColumnIndex == 0)
            {
                SqlDataReader dreader;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();
                cmd.CommandText = "Select ProdCod From Productos";
                conexion.Open();
                dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                        autocom.Add(dreader["ProdCod"].ToString());

                }
                else
                {
                    MessageBox.Show("ERROR");

                }
                dreader.Close();

                if (txtProdid != null)
                {
                    txtProdid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtProdid.AutoCompleteCustomSource = autocom;
                    txtProdid.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                conexion.Close();
            }
            else
            {
                txtProdid.AutoCompleteMode = AutoCompleteMode.None;
            }
            if (dataenca_compra.CurrentCell.ColumnIndex == 4)
            {
                conexion.Close();
                int rowindex = dataenca_compra.CurrentRow.Index;
                string cantida = dataenca_compra.Rows[rowindex].Cells["Column3"].Value.ToString();
                string val_unita = dataenca_compra.Rows[rowindex].Cells["Column4"].Value.ToString();
                int cantidad = System.Convert.ToInt32(cantida);
                int valor_unitario = System.Convert.ToInt32(val_unita);
                int resultado = cantidad * valor_unitario;
                dataenca_compra.Rows[rowindex].Cells["Column5"].Value = resultado;
            }
        }



        private void dataenca_compra_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataenca_compra.CurrentRow.Index;
            dataenca_compra[4, rowindex].Style.SelectionBackColor = Color.Red;
        }


        private void dataenca_compra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataenca_compra.Columns[e.ColumnIndex].Name == "Column1")
            {
                //string nombre = dataenca_compra.CurrentCell.Value.ToString();
                //MessageBox.Show(nombre);
                int rowindex = dataenca_compra.CurrentRow.Index;
                //try
                //{
                    string resul = dataenca_compra.Rows[rowindex].Cells["Column1"].Value.ToString();
                    if (resul != null)
                    {

                        string valor_re = datos.LLama_siexiste(resul);

                        if (valor_re == "1")
                        {
                            string getValue = datos.LLama_nombre(resul);
                            dataenca_compra.Rows[rowindex].Cells["Column2"].Value = getValue;
                            string resul1 = dataenca_compra.Rows[rowindex].Cells["Column2"].Value.ToString();
                            string valor_escalar = datos.LLama_costo(getValue);
                            dataenca_compra.Rows[rowindex].Cells["Column4"].Value = valor_escalar;
                        }
                        else
                        {
                            var cell = (sender as DataGridView).CurrentCell;
                            string message = "Desea Registrar el producto?";
                            string title = "VAVIYA";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                cell.Value = String.Empty;
                                Productos productos = new Productos();
                                productos.MdiParent = this.MdiParent;
                                productos.Show();
                            }
                            if (result == DialogResult.No)
                            {
                                cell.Value = String.Empty;
                            }


                        }
                    }
                //}
                //catch
                //{
                //            var cell = (sender as DataGridView).CurrentCell;
                //            string message = "Hay datos vacios";
                //            string title = "VAVIYA";
                //            MessageBoxButtons buttons = MessageBoxButtons.OK;
                //            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                //            if (result == DialogResult.OK)
                //            {
                //                cell.Value = String.Empty;
                               
                //            }


                //}

                
            }

            if (dataenca_compra.Columns[e.ColumnIndex].Name == "Column2")
            {
                //string nombre = dataenca_compra.CurrentCell.Value.ToString();
                //MessageBox.Show(nombre);
                int rowindex = dataenca_compra.CurrentRow.Index;
                //try
                //{
                string resul = dataenca_compra.Rows[rowindex].Cells["Column2"].Value.ToString();
                if (resul != null)
                {

                    string valor_re = datos.LLama_siexisteCodido(resul);

                    if (valor_re == "1")
                    {
                        string getValue = datos.LLama_nombreCod(resul);
                        dataenca_compra.Rows[rowindex].Cells["Column1"].Value = getValue;
                        string resul1 = dataenca_compra.Rows[rowindex].Cells["Column1"].Value.ToString();
                        string valor_escalar = datos.LLama_costo(resul);
                        dataenca_compra.Rows[rowindex].Cells["Column4"].Value = valor_escalar;
                    }
                    else
                    {
                        var cell = (sender as DataGridView).CurrentCell;
                        string message = "Desea Registrar el producto?";
                        string title = "VAVIYA";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            cell.Value = String.Empty;
                            Productos productos = new Productos();
                            productos.MdiParent = this.MdiParent;
                            productos.Show();
                        }
                        if (result == DialogResult.No)
                        {
                            cell.Value = String.Empty;
                        }


                    }
                }
                //}
                //catch
                //{
                //            var cell = (sender as DataGridView).CurrentCell;
                //            string message = "Hay datos vacios";
                //            string title = "VAVIYA";
                //            MessageBoxButtons buttons = MessageBoxButtons.OK;
                //            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                //            if (result == DialogResult.OK)
                //            {
                //                cell.Value = String.Empty;

                //            }


                //}


            }
            if (dataenca_compra.Columns[e.ColumnIndex].Name=="Column3")
            {
                try
                {
                    decimal precio_unit = decimal.Parse(dataenca_compra.Rows[e.RowIndex].Cells[3].Value.ToString());
                    int cantidad = int.Parse(dataenca_compra.Rows[e.RowIndex].Cells[2].Value.ToString());
                    decimal val_total = precio_unit * cantidad;
                    dataenca_compra.Rows[e.RowIndex].Cells[4].Value = val_total;
                    int numRows = dataenca_compra.Rows.Count;

                    int i = 0;
                    int suma = 0;
                    for (i = 0; i < (numRows - 1); i++)
                    {


                        suma += System.Convert.ToInt32(dataenca_compra.Rows[i].Cells[4].Value.ToString());
                    }
                    lb_total.Text= suma.ToString();
                    
                    //decimal suma = 0;
                    //foreach (DataGridViewRow row in dataenca_compra.Rows)
                    //{
                    //    suma += (decimal)row.Cells[4].Value;

                    //}


                    //total_compra.Text = suma.ToString();
                }
                catch
                {
                    var cell = (sender as DataGridView).CurrentCell;
                    string message = "Hay datos vacios";
                    string title = "VAVIYA";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        cell.Value = String.Empty;
                      
                    }
                }

            }
        }

        private void total_compra_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void but_guardar_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.Date.ToString("dd/MMM/yyyy");
            string valPrestamo = "";
            if (checkPrestamo.Checked == true)
            {
                valPrestamo = "S";
            }
            else
            {
                valPrestamo = "N";
            }
            try
            {
                

                string val = cb_proveedor.SelectedIndex.ToString();
                int valor = System.Convert.ToInt32(val);
                string cuanta = cb_proveedor.Items.Count.ToString();
                int num_item = System.Convert.ToInt32(cuanta);
                string id_provee = datos.obtiene_identi_persona("Proveedor", list_nombres.Items[valor].ToString(), list_apellidos.Items[valor].ToString());
                string val_reci = comboBox1.SelectedIndex.ToString();
                int valor_reci = System.Convert.ToInt32(val_reci);
                string cuanta_reci = comboBox1.Items.Count.ToString();
                int num_item_reci = System.Convert.ToInt32(cuanta_reci);
                string id_provee_reci = datos.obtiene_identi_persona("Empleado", lis_nom_em.Items[valor_reci].ToString(), lis_ape_em.Items[valor_reci].ToString());
                
                if (lb_total.Text != "")
                {
                    datos.LLama_inserta_encabezado(System.Convert.ToInt32(id_provee), System.Convert.ToInt32(id_provee_reci), System.Convert.ToDateTime(fecha), obrser_compra.Text, lb_total.Text, System.Convert.ToChar(valPrestamo));
                }
                else
                {
                    string message = "No hay datos registrados";
                    string title = "VAVIYA";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
            catch
            {
                string message = "Hay datos vacios";
                string title = "VAVIYA";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }

            foreach (DataGridViewRow row in dataenca_compra.Rows)
            {
                //Captura los elementos que hay dentro de un datagrid

                string id = (Convert.ToString(row.Cells["Column2"].Value));
                string cantidad = (Convert.ToString(row.Cells["Column3"].Value));
                string val_uni = (Convert.ToString(row.Cells["Column4"].Value));
                string val_tot = (Convert.ToString(row.Cells["Column5"].Value));
                //MessageBox.Show(Convert.ToString(row.Cells["Column3"].Value));
                //MessageBox.Show(Convert.ToString(row.Cells["Column4"].Value));
                //MessageBox.Show(Convert.ToString(row.Cells["Column5"].Value));

                if (id != "" && cantidad != "" && val_uni != "" && val_tot != "")
                {

                    int cantidad_in = System.Convert.ToInt32(cantidad);
                    float val_in = System.Convert.ToSingle(val_uni);
                    float tot_in = System.Convert.ToSingle(val_tot);
                    if (cod_compra.Text == "")
                    {
                        int codigo_compra = System.Convert.ToInt32(02);
                    }
                    else
                    {
                        int codigo_compra = System.Convert.ToInt32(cod_compra.Text);
                    }





                    string valor_re = datos.Obtiene_id(id);
                    
                    int id_in = System.Convert.ToInt32(valor_re);

                    int Codigo = System.Convert.ToInt32(cod_compra.Text);
                    datos.LLama_Inserta_cantidad(cantidad_in,id_in);
                    datos.LLama_guarda_movimientos(System.Convert.ToDateTime(fecha), id_in, cantidad_in, val_in, tot_in, Codigo,System.Convert.ToChar(valPrestamo));
                    //guarda todos los datos en la tabla movimientos


                }


            }
            string message1 = "Datos Guardados Correctamente";
            string title1 = "VAVIYA";
            MessageBoxButtons buttons1 = MessageBoxButtons.OK;
            DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Information);

            dataenca_compra.Rows.Clear();
            string valor_venta = datos.LLama_registro_compra();
            cod_compra.Text = valor_venta;
            cb_proveedor.Text = "";
            comboBox1.Text = "";
            obrser_compra.Text = "";
            lb_total.Text = "";

        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            frm_bienvenida bienve = new frm_bienvenida();
            bienve.MdiParent = this.MdiParent;
            bienve.Show();
            this.Close();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 10, 10);
        }


        Bitmap bmp;
        private void Bt_imprimir_Click(object sender, EventArgs e)
        {
            
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Refresh();
            groupBox1.Location = new Point(15, 12);
            dataenca_compra.Location = new Point(15, 195);
            label5.Location = new Point(15, 456);
            obrser_compra.Location = new Point(15, 480);
            label6.Location = new Point(500,553);
            lb_total.Location = new Point(600,553);
            but_guardar.Visible = false;
            bt_home.Visible = false;
            bt_imprimir.Visible = false;
            
            //padre bienve = new padre();
            //groupBox1.Location = new Point(15, 18);
            //dataGridView1.Location = new Point(15, 436);
            ////this.Size = new Size(500,this.Size.Height);
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            this.Visible = false;
            Enca_compra encabeza = new Enca_compra();
            encabeza.MdiParent = this.MdiParent;
            this.Close();
            encabeza.Show();
            printPreviewDialog1.ShowDialog();

        }

        private void PrintDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bt_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dr;
                dr = datos.obtiene_datos_encabezado(System.Convert.ToInt32(txt_buscar.Text));
                cod_compra.Text = dr.Rows[0][0].ToString();
                dateTimePicker1.Text = dr.Rows[0][3].ToString();
                //MessageBox.Show(dr.Rows[0][3].ToString());
                DataTable nombres;
                nombres = datos.inserta_nombre_apellido(System.Convert.ToInt32(dr.Rows[0][1].ToString()));
                cb_proveedor.Text = nombres.Rows[0][0].ToString() + " " + nombres.Rows[0][1].ToString();
                DataTable nombres_empleado;
                nombres_empleado = datos.inserta_nombre_apellido(System.Convert.ToInt32(dr.Rows[0][2].ToString()));
                comboBox1.Text = nombres_empleado.Rows[0][0].ToString() + " " + nombres_empleado.Rows[0][1].ToString();
                obrser_compra.Text = dr.Rows[0][4].ToString();
                lb_total.Text = dr.Rows[0][5].ToString();




                DataTable movimientos;
                movimientos = datos.trae_mov_compra(System.Convert.ToInt32(txt_buscar.Text));
                int i;
                for (i = 0; i < movimientos.Rows.Count; i++)
                {
                    DataTable detalle;
                    detalle = datos.trae_detalle_prod(System.Convert.ToInt32(movimientos.Rows[i][0].ToString()));
                    dataenca_compra.Rows.Add(detalle.Rows[0][0].ToString(), detalle.Rows[0][1].ToString(), movimientos.Rows[i][1].ToString(), movimientos.Rows[i][2].ToString(), movimientos.Rows[i][3].ToString());

                }
            }
            catch
            {
                MessageBox.Show("Factura Incorrecta");
            }

        }

        private void Bt_el_data_Click(object sender, EventArgs e)
        {
          
            dataenca_compra.Rows.RemoveAt(dataenca_compra.CurrentRow.Index);
        }

        private void Bt_eliminar_Click(object sender, EventArgs e)
        {
            dataenca_compra.Rows.Clear();
        }
    }
}
