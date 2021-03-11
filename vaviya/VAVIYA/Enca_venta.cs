using BusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAVIYA
{
    public partial class Enca_venta : Form
    {
        SqlConnection conexion = new SqlConnection("Server=(localdb)\\Vaviya;DataBase=Vaviya12; integrated security= true");
        EncVentaBL datos = new EncVentaBL();
        public decimal valVenta_Total;//Variable global que almacena el valor total de cada articulo
        public string res_Descuento;
        public decimal val_unita;

        public Enca_venta()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
    }

        private void Enca_venta_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Now;
            dataenca_venta.ColumnHeadersDefaultCellStyle.BackColor = Color.PaleGoldenrod;
            dataenca_venta.EnableHeadersVisualStyles = false;
            //dataenca_venta.Columns["Column5"].ReadOnly = true;
            //dataenca_venta.Columns["Column3"].ReadOnly = true;
            dataenca_venta.Columns["Column4"].ReadOnly = false;
            //asigna el numero de compra de una factura 
            string valor_re = datos.LLama_registro_venta(); 
            cod_venta.Text = valor_re;
            conexion.Open();
            DataTable dr;
            dr = datos.obtiene_nombres_persona("empleado");
            int i;
            for (i = 0; i < dr.Rows.Count; i++)
            {

                cb_vendedor.Items.Add(dr.Rows[i][0].ToString() + " " + dr.Rows[i][1].ToString());
                lis_nom_em.Items.Add(dr.Rows[i][0].ToString());
                lis_ape_em.Items.Add(dr.Rows[i][1].ToString());
            }

            DataTable dl;
            dl = datos.obtiene_nombres_persona("cliente");
            int j;
            for (j = 0; j < dl.Rows.Count; j++)
            {

                cb_cliente.Items.Add(dl.Rows[j][0].ToString() + " " + dl.Rows[j][1].ToString());
                list_nombres.Items.Add(dl.Rows[j][0].ToString());
                list_apellidos.Items.Add(dl.Rows[j][1].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string valPrestamo = "";
                string id_provee="";
                string val_empleado = cb_vendedor.SelectedIndex.ToString();
                int valor_emple = System.Convert.ToInt32(val_empleado);
                string val2 = cb_cliente.SelectedIndex.ToString();
                int valor1 = System.Convert.ToInt32(val2);
                string id_provee_reci = datos.obtiene_identi_persona("Empleado", lis_nom_em.Items[valor_emple].ToString(), lis_ape_em.Items[valor_emple].ToString());
                //Inserta los valores en el encabezado 
                if (checkPrestamo.Checked == true)
                {
                    valPrestamo = "S";
                }
                else {
                    valPrestamo = "N";
                }
                if (valor1 >= 0)
                {

                    id_provee = datos.obtiene_identi_persona("Cliente", list_nombres.Items[valor1].ToString(), list_apellidos.Items[valor1].ToString());
                    
                    Boolean bandera = true;
                    foreach (DataGridViewRow row in dataenca_venta.Rows)
                    {

                        //Captura los elementos que hay dentro de un datagrid

                        string id = (Convert.ToString(row.Cells["Column1"].Value));
                        string cantidad = (Convert.ToString(row.Cells["Column2"].Value));
                        string val_uni = (Convert.ToString(row.Cells["Column3"].Value));
                        string val_tot = (Convert.ToString(row.Cells["Column4"].Value));
                        string nombre = (Convert.ToString(row.Cells["Column5"].Value));
                        string porc_articulo = (Convert.ToString(row.Cells["colum_descuento"].Value));


                        //MessageBox.Show(porc_articulo.Replace(".",""));
                        porc_articulo = porc_articulo.TrimEnd('%');
                        //MessageBox.Show(Convert.ToString(row.Cells["Column3"].Value));
                        //MessageBox.Show(Convert.ToString(row.Cells["Column4"].Value));
                        //MessageBox.Show(Convert.ToString(row.Cells["Column5"].Value));

                        if (id != "" && cantidad != "" && val_uni != "" && val_tot != "" )
                        {
                            int res = System.Convert.ToInt32(cod_venta.Text);
                            if (datos.VerificaIdVenta(res) > 0)
                            {



                                int id_prod = System.Convert.ToInt32(datos.Obtiene_id(id));

                                if (datos.consulta_prodMovimiento(res, id_prod) == "1")
                                {
                                    //MessageBox.Show("entra qui");
                                    datos.ActuaCanProd(res, id_prod);
                                }







                            }
                            //MessageBox.Show("Luego va aqui");
                            int cantidad_in = System.Convert.ToInt32(cantidad);
                            float val_in = System.Convert.ToSingle(val_uni);
                            float tot_in = System.Convert.ToSingle(val_tot);
                            int codigo_compra = System.Convert.ToInt32(cod_venta.Text);
                            int porcentaje = System.Convert.ToInt32(porc_articulo);


                            string val = cb_cliente.SelectedIndex.ToString();
                            int valor = System.Convert.ToInt32(val);
                            string cuanta = cb_cliente.Items.Count.ToString();
                            int num_item = System.Convert.ToInt32(cuanta);


                            string val_reci = cb_vendedor.SelectedIndex.ToString();
                            int valor_reci = System.Convert.ToInt32(val_reci);
                            string cuanta_reci = cb_vendedor.Items.Count.ToString();
                            int num_item_reci = System.Convert.ToInt32(cuanta_reci);




                            string valor_re = datos.Obtiene_id(id);

                            //id de cada producto facturado en una venta
                            int id_in = System.Convert.ToInt32(valor_re);
                            string res_canti = datos.obtiene_cantidad_producto(id_in);
                            //Trae las cantidades de cada producto
                            try
                            {
                                int cantidad_final=0;
                                if (nombre != "Mantenimiento")
                                {
                                    cantidad_final = System.Convert.ToInt32(res_canti) - cantidad_in;
                                }
                                

                                if (cantidad_final >= 0 && bandera == true)
                                {
                                   
                                    bandera = true;



                                }

                                else
                                {
                                    //MessageBox.Show("Aqui Pega1");
                                    string message = "Cantidad Insuficiente";
                                    string title = "VAVIYA";
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                    bandera = true;

                                }
                            }
                            catch
                            {
                                bandera = false;

                                string message = "Cantidad Insuficiente";
                                string title = "VAVIYA";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                            }
                        }
                    }

                    //MessageBox.Show("hasta aui Ok"); 
                    //MessageBox.Show(bandera.ToString());
                    if (bandera == true)
                    {
                        foreach (DataGridViewRow row in dataenca_venta.Rows)
                        {

                            //Captura los elementos que hay dentro de un datagrid

                            string id = (Convert.ToString(row.Cells["Column1"].Value));
                            string cantidad = (Convert.ToString(row.Cells["Column2"].Value));
                            string val_uni = (Convert.ToString(row.Cells["Column3"].Value));
                            string val_tot = (Convert.ToString(row.Cells["Column4"].Value));
                            string porc_articulo = (Convert.ToString(row.Cells["colum_descuento"].Value));
                            string nombre = (Convert.ToString(row.Cells["Column5"].Value));
                            string IvaProd;
                            if (System.Convert.ToString(row.Cells["IvaProd"].Value) != "")
                            {
                                IvaProd = (Convert.ToString(row.Cells["IvaProd"].Value));
                            }
                            else
                            {
                                IvaProd = "19";
                            }
                            

                            //MessageBox.Show(porc_articulo.Replace(".",""));
                            porc_articulo = porc_articulo.TrimEnd('%');
                            //MessageBox.Show(Convert.ToString(row.Cells["Column3"].Value));
                            //MessageBox.Show(Convert.ToString(row.Cells["Column4"].Value));
                            //MessageBox.Show(Convert.ToString(row.Cells["Column5"].Value));

                            if (id != "" && cantidad != "" && val_uni != "" && val_tot != "")
                            {
                                int res = System.Convert.ToInt32(cod_venta.Text);
                                if (datos.VerificaIdVenta(res) > 0)
                                {



                                    int id_prod = System.Convert.ToInt32(datos.Obtiene_id(id));

                                    //if (datos.consulta_prodMovimiento(res, id_prod) == "1")
                                    //{
                                    //    MessageBox.Show("Aquix2");
                                    //    datos.ActuaCanProd(res, id_prod);
                                    //}







                                }

                                int cantidad_in = System.Convert.ToInt32(cantidad);
                                float val_in = System.Convert.ToSingle(val_uni);
                                float tot_in = System.Convert.ToSingle(val_tot);
                                int codigo_compra = System.Convert.ToInt32(cod_venta.Text);
                                int porcentaje = System.Convert.ToInt32(porc_articulo);

                                int Iva = System.Convert.ToInt32(IvaProd);

                                string val = cb_cliente.SelectedIndex.ToString();
                                int valor = System.Convert.ToInt32(val);
                                string cuanta = cb_cliente.Items.Count.ToString();
                                int num_item = System.Convert.ToInt32(cuanta);


                                string val_reci = cb_vendedor.SelectedIndex.ToString();
                                int valor_reci = System.Convert.ToInt32(val_reci);
                                string cuanta_reci = cb_vendedor.Items.Count.ToString();
                                int num_item_reci = System.Convert.ToInt32(cuanta_reci);




                                string valor_re = datos.Obtiene_id(id);

                                //id de cada producto facturado en una venta
                                int id_in = System.Convert.ToInt32(valor_re);
                                string res_canti = datos.obtiene_cantidad_producto(id_in);
                                //Trae las cantidades de cada producto
                                try
                                {
                                    int cantidad_final = 0;

                                    if (nombre != "Mantenimiento")
                                    {
                                        cantidad_final = System.Convert.ToInt32(res_canti) - cantidad_in;
                                    }
                                    else
                                    {
                                        
                                        string fecha = dateTimePicker1.Value.Date.ToString("dd/MMM/yyyy");
                                        datos.LLama_inserta_encabezado(System.Convert.ToInt32(cod_venta.Text), System.Convert.ToInt32(id_provee), System.Convert.ToDateTime(fecha), System.Convert.ToInt32(id_provee_reci), textBox5.Text, txt_total.Text, System.Convert.ToChar(valPrestamo));
                                        datos.LLama_Inserta_cantidad(cantidad_in, id_in);
                                        //guarda todos los datos en la tabla movimientos
                                        int Codigo = System.Convert.ToInt32(cod_venta.Text);
                                        datos.LLama_guarda_movimientos(System.Convert.ToDateTime(fecha), id_in, cantidad_in, val_in, tot_in, Codigo, porcentaje,Iva, System.Convert.ToChar(valPrestamo));
                                        bandera = true;
                                    }
                                    

                                    if (cantidad_final >= 0 && bandera == true)
                                    {
                                        //MessageBox.Show("Aqui guarda");
                                        string fecha = dateTimePicker1.Value.Date.ToString("dd/MMM/yyyy");
                                        datos.LLama_inserta_encabezado(System.Convert.ToInt32(cod_venta.Text), System.Convert.ToInt32(id_provee), System.Convert.ToDateTime(fecha), System.Convert.ToInt32(id_provee_reci), textBox5.Text, txt_total.Text, System.Convert.ToChar(valPrestamo));
                                        datos.LLama_Inserta_cantidad(cantidad_final, id_in);
                                        //guarda todos los datos en la tabla movimientos
                                        int Codigo = System.Convert.ToInt32(cod_venta.Text);
                                        datos.LLama_guarda_movimientos(System.Convert.ToDateTime(fecha), id_in, cantidad_in, val_in, tot_in, Codigo, porcentaje,Iva, System.Convert.ToChar(valPrestamo));
                                        bandera = true;



                                    }

                                    else
                                    {
                                        //MessageBox.Show("Aqui Pega");
                                        string message = "Cantidad Insuficiente";
                                        string title = "VAVIYA";
                                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                        bandera = false;
                                        row.Cells["Column1"].Style.BackColor = Color.Red;
                                    }
                                }
                                catch
                                {
                                    row.Cells["Column1"].Style.BackColor = Color.Red;
                                    string message = "Cantidad Insuficiente";
                                    string title = "VAVIYA";
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                                }
                            }
  
                        }
                        string message_print = "Desea Imprimir?";
                        string title_print = "VAVIYA";
                        MessageBoxButtons buttons_print = MessageBoxButtons.YesNo;
                        DialogResult result_print = MessageBox.Show(message_print, title_print, buttons_print, MessageBoxIcon.Information);
                        if (result_print == DialogResult.Yes)
                        {
                            this.llama_print();
                            string message1 = "Datos Guardados Correctamente";
                            string title1 = "VAVIYA";
                            MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                            DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Information);

                            dataenca_venta.Rows.Clear();
                            string valor_venta = datos.LLama_registro_venta();
                            cod_venta.Text = valor_venta;
                            cb_cliente.Text = "";
                            cb_vendedor.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            txt_descuento.Text = "";
                            txt_total.Text = "";
                            Enca_venta Enca_Venta = new Enca_venta();
                            Enca_Venta.MdiParent = this.MdiParent;
                            Enca_Venta.Show();
                        }
                    }























                }
                else
                {

                    string message = "Cliente no registrado, desea registarlo?";
                    string title = "VAVIYA";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }


            }
            catch
            {

                string message = "Los Campos Vendedor y Cliente son obligatorios";
                string title = "VAVIYA";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }



        }

        private void dataenca_venta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //try
                //{
                //    if (dataenca_venta.Rows[e.RowIndex].Cells[1].Value.ToString() == "Mantenimiento")
                //    {
                //        dataenca_venta.Columns["Column3"].ReadOnly = false;
                //    }

                //    else
                //    {
                //        dataenca_venta.Columns["Column3"].ReadOnly = true;
                //    }
                //}
                //catch
                //{
                //    MessageBox.Show("Datos Incorrectos");
                //}

                if (dataenca_venta.Columns[e.ColumnIndex].Name == "Column1")
                {
                    //string nombre = dataenca_compra.CurrentCell.Value.ToString();
                    //MessageBox.Show(nombre);
                    if (dataenca_venta.Rows[e.RowIndex].Cells[0].Value.ToString() == "Mant")
                    {
                        dataenca_venta.Columns["Column3"].ReadOnly = false;
                    }
                    else
                    {
                        dataenca_venta.Columns["Column3"].ReadOnly = true;
                    }
                    int rowindex = dataenca_venta.CurrentRow.Index;
                    try
                    {
                        string resul = dataenca_venta.Rows[rowindex].Cells["Column1"].Value.ToString();
                        if (resul != null)
                        {
                            //string cantidad = dataenca_compra.Rows[rowindex].Cells["Column3"].Value.ToString();
                            //string valor = dataenca_compra.Rows[rowindex].Cells["Column4"].Value.ToString(
                            string valor_re = datos.LLama_siexisteCodido(resul);
                            //MessageBox.Show(valor_re);
                            if (valor_re == "1")
                            {
                                string getValue = datos.LLama_nombreCod(resul);
                                dataenca_venta.Rows[rowindex].Cells["Column5"].Value = getValue;

                                dataenca_venta.Rows[rowindex].Cells["Column2"].Value=1;
                                string valor_escalar = datos.LLama_costo(getValue);
                                dataenca_venta.Rows[rowindex].Cells["Column3"].Value = valor_escalar;

                                string valor_iva = datos.LLama_iva(getValue);
                                dataenca_venta.Rows[rowindex].Cells["IvaProd"].Value = valor_iva;


                                decimal precio_unit = decimal.Parse(dataenca_venta.Rows[e.RowIndex].Cells[3].Value.ToString());
                                int cantidad = int.Parse(dataenca_venta.Rows[e.RowIndex].Cells[2].Value.ToString());
                                decimal val_total = precio_unit * cantidad;
                                valVenta_Total = val_total;//entrega el valor total de la venta

                                dataenca_venta.Rows[e.RowIndex].Cells[5].Value = val_total;
                                dataenca_venta.Rows[e.RowIndex].Cells[4].Value = "0%";
                                int numRows = dataenca_venta.Rows.Count;

                                int i = 0;
                                int suma = 0;
                                double probando = 0;
                                double descuento = 0;
                                for (i = 0; i < (numRows - 1); i++)
                                {

                                    try
                                    {
                                        suma += System.Convert.ToInt32(dataenca_venta.Rows[i].Cells[5].Value.ToString());
                                        probando = suma;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Los datos son incorrectos");
                                    }

                                }
                                textBox6.Text = suma.ToString();
                                if (txt_descuento.Text != "")
                                {
                                    descuento = System.Convert.ToDouble(txt_descuento.Text);
                                    txt_total.Text = (probando * (descuento / 100)).ToString();
                                }
                                txt_total.Text = suma.ToString();


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
                                    productos.Show();
                                }
                                if (result == DialogResult.No)
                                {
                                    cell.Value = String.Empty;
                                }


                            }






                        }
                    }
                    catch
                    {
                        MessageBox.Show("El Campo ID no puede estar vacio");
                    }


                }


                if (dataenca_venta.Columns[e.ColumnIndex].Name == "Column5")
                {
                    if (dataenca_venta.Rows[e.RowIndex].Cells[1].Value.ToString() == "Mantenimiento")
                    {
                        dataenca_venta.Columns["Column3"].ReadOnly = false;
                    }

                    else
                    {
                        dataenca_venta.Columns["Column3"].ReadOnly = true;
                    }
                    //string nombre = dataenca_compra.CurrentCell.Value.ToString();
                    //MessageBox.Show(nombre);
                    int rowindex = dataenca_venta.CurrentRow.Index;
                    try
                    {
                        string resul = dataenca_venta.Rows[rowindex].Cells["Column5"].Value.ToString();
                        if (resul != null)
                        {
                            //string cantidad = dataenca_compra.Rows[rowindex].Cells["Column3"].Value.ToString();
                            //string valor = dataenca_compra.Rows[rowindex].Cells["Column4"].Value.ToString(
                            string valor_re = datos.LLama_siexiste(resul);
                            //MessageBox.Show(valor_re);
                            if (valor_re == "1")
                            {
                                string getValue = datos.LLama_nombre(resul);
                                dataenca_venta.Rows[rowindex].Cells["Column1"].Value = getValue;

                                dataenca_venta.Rows[rowindex].Cells["Column2"].Value = 1;
                                string valor_escalar = datos.LLama_costo(resul);
                                dataenca_venta.Rows[rowindex].Cells["Column3"].Value = valor_escalar;

                                string valor_iva = datos.LLama_iva(resul);
                                dataenca_venta.Rows[rowindex].Cells["IvaProd"].Value = valor_iva;


                                decimal precio_unit = decimal.Parse(dataenca_venta.Rows[e.RowIndex].Cells[3].Value.ToString());
                                int cantidad = int.Parse(dataenca_venta.Rows[e.RowIndex].Cells[2].Value.ToString());
                                decimal val_total = precio_unit * cantidad;
                                valVenta_Total = val_total;//entrega el valor total de la venta

                                dataenca_venta.Rows[e.RowIndex].Cells[5].Value = val_total;
                                dataenca_venta.Rows[e.RowIndex].Cells[4].Value = "0%";
                                int numRows = dataenca_venta.Rows.Count;

                                int i = 0;
                                int suma = 0;
                                double probando = 0;
                                double descuento = 0;
                                for (i = 0; i < (numRows - 1); i++)
                                {

                                    try
                                    {
                                        suma += System.Convert.ToInt32(dataenca_venta.Rows[i].Cells[5].Value.ToString());
                                        probando = suma;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Los datos son incorrectos");
                                    }

                                }
                                textBox6.Text = suma.ToString();
                                if (txt_descuento.Text != "")
                                {
                                    descuento = System.Convert.ToDouble(txt_descuento.Text);
                                    txt_total.Text = (probando * (descuento / 100)).ToString();
                                }
                                txt_total.Text = suma.ToString();


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
                                    productos.Show();
                                }
                                if (result == DialogResult.No)
                                {
                                    cell.Value = String.Empty;
                                }


                            }






                        }
                    }
                    catch
                    {
                        MessageBox.Show("El Campo ID no puede estar vacio");
                    }


                }
                if (dataenca_venta.Columns[e.ColumnIndex].Name == "Column2")
                {
                    try
                    {
                        try
                        {
                            decimal precio_unit = decimal.Parse(dataenca_venta.Rows[e.RowIndex].Cells[3].Value.ToString());
                            int cantidad = int.Parse(dataenca_venta.Rows[e.RowIndex].Cells[2].Value.ToString());
                            decimal val_total = precio_unit * cantidad;
                            valVenta_Total = val_total;//entrega el valor total de la venta

                            dataenca_venta.Rows[e.RowIndex].Cells[5].Value = val_total;
                            dataenca_venta.Rows[e.RowIndex].Cells[4].Value = "0%";
                            int numRows = dataenca_venta.Rows.Count;

                            int i = 0;
                            int suma = 0;
                            double probando = 0;
                            double descuento = 0;
                            for (i = 0; i < (numRows - 1); i++)
                            {

                                try
                                {
                                    suma += System.Convert.ToInt32(dataenca_venta.Rows[i].Cells[5].Value.ToString());
                                    probando = suma;
                                }
                                catch
                                {
                                    MessageBox.Show("Los datos son incorrectos");
                                }

                            }
                            textBox6.Text = suma.ToString();
                            if (txt_descuento.Text != "")
                            {
                                descuento = System.Convert.ToDouble(txt_descuento.Text);
                                txt_total.Text = (probando * (descuento / 100)).ToString();
                            }
                            txt_total.Text = suma.ToString();

                        }
                        catch
                        {
                            MessageBox.Show("Hay datos vacios");
                        }


                    }
                    catch
                    {
                        MessageBox.Show("Hay datos vacios");
                    }

                }
                if (dataenca_venta.Columns[e.ColumnIndex].Name == "Column4")
                {
                    try
                    {
                        try
                        {
                            decimal cantidad = System.Convert.ToInt32(dataenca_venta.Rows[e.RowIndex].Cells[2].Value);
                            decimal val_uni = System.Convert.ToInt32(dataenca_venta.Rows[e.RowIndex].Cells[3].Value);
                            decimal ValVenta = cantidad * val_uni;
                            decimal val_total = System.Convert.ToInt32(dataenca_venta.Rows[e.RowIndex].Cells[5].Value);

                            double val1 = 0;
                            double val2 = 0;


                            if (txt_total.Text != "" && textBox6.Text != "")
                            {
                                val1 = System.Convert.ToDouble(textBox6.Text);
                                val2 = System.Convert.ToDouble(txt_total.Text);
                                res_Descuento = (Math.Round(((ValVenta - val_total) * 100) / ValVenta, 0)).ToString() + "%";
                            }
                            dataenca_venta.Rows[e.RowIndex].Cells[4].Value = res_Descuento;
                            int numRows = dataenca_venta.Rows.Count;

                            int i = 0;
                            int suma = 0;
                            double probando = 0;
                            double descuento = 0;
                            for (i = 0; i < (numRows - 1); i++)
                            {


                                suma += System.Convert.ToInt32(dataenca_venta.Rows[i].Cells[5].Value.ToString());
                                probando = suma;
                            }
                            textBox6.Text = suma.ToString();
                            if (txt_descuento.Text != "")
                            {
                                descuento = System.Convert.ToDouble(txt_descuento.Text);
                                txt_total.Text = (probando * (descuento / 100)).ToString();
                            }
                            txt_total.Text = suma.ToString();

                        }
                        catch
                        {
                            MessageBox.Show("Hay datos vacios");
                        }


                    }
                    catch
                    {
                        MessageBox.Show("Hay datos vacios");
                    }

                }
                if (dataenca_venta.Columns[e.ColumnIndex].Name == "IvaProd")
                {
                    //try
                    //{
                    //    try
                    //    {
                    //        double precio_unit = double.Parse(dataenca_venta.Rows[e.RowIndex].Cells[6].Value.ToString())/100;
                    //        double val = double.Parse(dataenca_venta.Rows[e.RowIndex].Cells[5].Value.ToString());
                    //        double val_total = (precio_unit+1.00) / val;
                    //        //entrega el valor total de la venta

                    //        dataenca_venta.Rows[e.RowIndex].Cells[5].Value = val_total;
                    //        dataenca_venta.Rows[e.RowIndex].Cells[4].Value = "0%";


                    //    }
                    //    catch
                    //    {
                    //        MessageBox.Show("Hay datos vacios");
                    //    }


                    //}
                    //catch
                    //{
                    //    MessageBox.Show("Hay datos vacios");
                    //}

                }
            }
            catch
            {
                MessageBox.Show("Datos Incorrectos");
            }
            
        }

        private void dataenca_venta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            SqlConnection conexion = new SqlConnection("Server=(localdb)\\Vaviya;DataBase=Vaviya12; integrated security= true");
            
            TextBox txtProdid = e.Control as TextBox;

            if (dataenca_venta.CurrentCell.ColumnIndex == 1)
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
                    MessageBox.Show("Datos incorrectos");

                }
                dreader.Close();
                txtProdid = e.Control as TextBox;
                if (txtProdid != null)
                {
                    txtProdid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtProdid.AutoCompleteCustomSource = autocom;
                    txtProdid.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                conexion.Close();
            }
            else if (dataenca_venta.CurrentCell.ColumnIndex == 0)
            {
                SqlDataReader dreader;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                AutoCompleteStringCollection autocom = new AutoCompleteStringCollection();
                cmd.CommandText = "Select Prodcod From Productos";
                conexion.Open();
                dreader = cmd.ExecuteReader();
                if (dreader.HasRows == true)
                {
                    while (dreader.Read())
                        autocom.Add(dreader["ProdCod"].ToString());

                }
                else
                {
                    MessageBox.Show("Datos incorrectos");

                }
                dreader.Close();
                txtProdid = e.Control as TextBox;
                if (txtProdid != null)
                {
                    txtProdid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtProdid.AutoCompleteCustomSource = autocom;
                    txtProdid.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                conexion.Close();
            }
            else {
                txtProdid.AutoCompleteMode = AutoCompleteMode.None;
            }
            if (dataenca_venta.CurrentCell.ColumnIndex == 4)
            {

                int rowindex = dataenca_venta.CurrentRow.Index;
                string cantida = dataenca_venta.Rows[rowindex].Cells["Column2"].Value.ToString();
                string val_unita = dataenca_venta.Rows[rowindex].Cells["Column3"].Value.ToString();
                int cantidad = System.Convert.ToInt32(cantida);
                int valor_unitario = System.Convert.ToInt32(val_unita);
                int resultado = cantidad * valor_unitario;
                dataenca_venta.Rows[rowindex].Cells["Column4"].Value = resultado;
            }
        }



        private void txt_descuento_TextChanged(object sender, EventArgs e)
        {
          
            
            double descuento = 0;
            double probando = 0;

            if (txt_descuento.Text != "" && txt_total.Text != "")
            {
                probando = System.Convert.ToDouble(textBox6.Text);
                descuento = System.Convert.ToDouble(txt_descuento.Text);
                txt_total.Text = (probando - (probando * (descuento / 100))).ToString();
            }
        }

        private void cb_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_provee = "";
            string val2 = cb_cliente.SelectedIndex.ToString();
            int valor1 = System.Convert.ToInt32(val2);
           
            //Inserta los valores en el encabezado 

            if (valor1 >= 0)
            {
                id_provee = datos.obtiene_identi_persona("Cliente", list_nombres.Items[valor1].ToString(), list_apellidos.Items[valor1].ToString());
            }
            else
            {

                MessageBox.Show("El cliente no esta registrado");
            }
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            frm_bienvenida bienve = new frm_bienvenida();
            bienve.MdiParent = this.MdiParent;
            bienve.Show();
            this.Close();
        }

        private void Txt_descuento_Enter(object sender, EventArgs e)
        {
            //double descuento = 0;
            //double probando = 0;

            //if (txt_descuento.Text != "")
            //{
            //    descuento = System.Convert.ToDouble(txt_descuento.Text);
            //    txt_total.Text = (probando * (descuento / 100)).ToString();
            //}
        }

        private void Txt_descuento_TabIndexChanged(object sender, EventArgs e)
        {
            //double descuento = 0;
            //double probando = 0;

            //if (txt_descuento.Text != "")
            //{
            //    descuento = System.Convert.ToDouble(txt_descuento.Text);
            //    txt_total.Text = (probando * (descuento / 100)).ToString();
            //}
        }

        private void Bt_buscar_Click(object sender, EventArgs e)
        {
            DataTable dr;
            dr = datos.obtiene_datos_encabezado(System.Convert.ToInt32(txt_buscar.Text));
            cod_venta.Text = dr.Rows[0][0].ToString();
            dateTimePicker1.Text = dr.Rows[0][2].ToString();
            
            DataTable nombres;
            nombres = datos.inserta_nombre_apellido(System.Convert.ToInt32(dr.Rows[0][1].ToString()));
            cb_cliente.Text = nombres.Rows[0][0].ToString() + " " + nombres.Rows[0][1].ToString();
            DataTable nombres_empleado;
            nombres_empleado = datos.inserta_nombre_apellido(System.Convert.ToInt32(dr.Rows[0][3].ToString()));
            cb_vendedor.Text = nombres_empleado.Rows[0][0].ToString() + " " + nombres_empleado.Rows[0][1].ToString();
            textBox5.Text = dr.Rows[0][4].ToString();
            //textBox6.Text = dr.Rows[0][5].ToString();
            txt_total.Text = dr.Rows[0][5].ToString();

            //Valida si es un prestamo y activa el checkbox
            string si = System.Convert.ToString(dr.Rows[0][6].ToString());
            if (si==" S" +
                "")
            {
                MessageBox.Show("Entro");
                checkPrestamo.Checked = true;
            }
            else 
            {
                MessageBox.Show(dr.Rows[0][6].ToString());
                checkPrestamo.Checked = false;
            }



            DataTable movimientos;
            movimientos = datos.trae_mov_venta(System.Convert.ToInt32(txt_buscar.Text));
            int i;
            for (i = 0; i < movimientos.Rows.Count; i++)
            {
                DataTable detalle;
                detalle = datos.trae_detalle_prod(System.Convert.ToInt32(movimientos.Rows[i][0].ToString()));
                dataenca_venta.Rows.Add(detalle.Rows[0][0].ToString(), detalle.Rows[0][1].ToString(), movimientos.Rows[i][1].ToString(), movimientos.Rows[i][2].ToString());
                dataenca_venta.Rows[i].Cells[5].Value =movimientos.Rows[i][3].ToString();
                dataenca_venta.Rows[i].Cells[6].Value = movimientos.Rows[i][4].ToString();
                dataenca_venta.Rows[i].Cells[4].Value = movimientos.Rows[i][5].ToString();

                decimal precio_unit = decimal.Parse(dataenca_venta.Rows[i].Cells[3].Value.ToString());
                int cantidad = int.Parse(dataenca_venta.Rows[i].Cells[2].Value.ToString());
                decimal val_total = precio_unit * cantidad;
                valVenta_Total = val_total;//entrega el valor total de la venta

                //dataenca_venta.Rows[i].Cells[5].Value = val_total;
                //dataenca_venta.Rows[i].Cells[4].Value = "0%";
                
            }

            int numRows = dataenca_venta.Rows.Count;
            int j = 0;
            int suma = 0;
            double probando = 0;
            double descuento = 0;
            
            for (j = 0; j < (numRows - 1); j++)
            {

                try
                {
                    suma += System.Convert.ToInt32(dataenca_venta.Rows[j].Cells[5].Value.ToString());
                    probando = suma;
                }
                catch
                {
                    MessageBox.Show("Los datos son incorrectos");
                }

            }
            textBox6.Text = suma.ToString();
            //if (txt_descuento.Text != "")
            //{
            //    descuento = System.Convert.ToDouble(txt_descuento.Text);
            //    txt_total.Text = (probando * (descuento / 100)).ToString();
            //}
            //txt_total.Text = suma.ToString();
        }

        private void Bt_eliminar_Click(object sender, EventArgs e)
        {
            dataenca_venta.Rows.Clear();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Bt_el_data_Click(object sender, EventArgs e)
        {
            try
            {
               
                int res = System.Convert.ToInt32(cod_venta.Text);
                if (datos.VerificaIdVenta(res) > 0)
                {
                    int numCol = dataenca_venta.CurrentRow.Index;




                    int id_prod = System.Convert.ToInt32(datos.Obtiene_id(System.Convert.ToString(dataenca_venta.Rows[numCol].Cells["Column1"].Value)));

                    datos.ActuaCanProd(res, id_prod);

                    dataenca_venta.Rows.RemoveAt(dataenca_venta.CurrentRow.Index);
                    datos.EliminaMovProd(res, id_prod);
                }
                else {
                    dataenca_venta.Rows.RemoveAt(dataenca_venta.CurrentRow.Index);

                }




            }
            catch
            {
                MessageBox.Show("No hay articulos");
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void dataenca_venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llama_print()
        {
            Datos datos = new Datos();
            FactVenta fac = new FactVenta();

            ArrayList Iva19 = new ArrayList();
            ArrayList Iva05 = new ArrayList();
            ArrayList Iva00 = new ArrayList();
            decimal sum19 = 0;
            decimal sum05 = 0;
            decimal sum00 = 0;
            for (int i = 0; i < dataenca_venta.Rows.Count - 1; i++)
            {

                Datos datos1 = new Datos();
                datos1.CodProd = Convert.ToString(dataenca_venta.Rows[i].Cells[0].Value);
                datos1.NomProducto = Convert.ToString(dataenca_venta.Rows[i].Cells[1].Value);
                datos1.Cantidad = Convert.ToString( dataenca_venta.Rows[i].Cells[2].Value);
                decimal val_unitario =Convert.ToDecimal( dataenca_venta.Rows[i].Cells[3].Value);
                datos1.ValUnitario = Convert.ToString(val_unitario);
                datos1.ValTotProd = Convert.ToString(dataenca_venta.Rows[i].Cells[5].Value);
                


                if (System.Convert.ToString(dataenca_venta.Rows[i].Cells[6].Value) == "")
                {
                    sum19 = sum19 + System.Convert.ToDecimal(dataenca_venta.Rows[i].Cells[5].Value);
                    
                    //double op = Math.Round((float)val_unitario / 1.19, 1);
                    //datos1.ValUnitario = Convert.ToString(op);
                    //datos1.ValTotProd = Convert.ToString((float)val_unitario - op);
                    //datos1.Iva = Convert.ToString(19);
                }
                else {
                    decimal val_iva = (System.Convert.ToDecimal(dataenca_venta.Rows[i].Cells[6].Value));
                    if (val_iva == 19)
                    {
                        sum19 = sum19 + System.Convert.ToDecimal(dataenca_venta.Rows[i].Cells[5].Value);


                    }
                    else if (val_iva == 5)
                    {
                        sum05 = sum05 + System.Convert.ToDecimal(dataenca_venta.Rows[i].Cells[5].Value);


                    }
                    if (val_iva == 0)
                    {
                        sum00 = sum00 + System.Convert.ToDecimal(dataenca_venta.Rows[i].Cells[5].Value);


                    }
                    

                }  
                fac.datos1.Add(datos1);
            }
            if (sum19 > 0)
            {
                Datos datos2 = new Datos();
                double op = Math.Round((float)sum19/ 1.19, 1);
                datos2.Base = Convert.ToString(op);

                //datos1.ValUnitario = Convert.ToString(op);
                datos2.Impt = Convert.ToString((float)sum19 - op);
                datos2.Iva = Convert.ToString(19);
                fac.datos2.Add(datos2);
            }
            if (sum05 > 0)
            {
                Datos datos2 = new Datos();
                double op = Math.Round((float)sum05 / 1.05, 1);
                datos2.Base = Convert.ToString(op);

                //datos1.ValUnitario = Convert.ToString(op);
                datos2.Impt = Convert.ToString(Math.Round( (float)sum05 - op,1));
                datos2.Iva = Convert.ToString(5);
                fac.datos2.Add(datos2);
            }
            if (sum00 > 0)
            {
                Datos datos2 = new Datos();
                double op = Math.Round((float)sum05 / 1.00, 1);
                datos2.Base = Convert.ToString(op);

                //datos1.ValUnitario = Convert.ToString(op);
                datos2.Impt = Convert.ToString(Math.Round((float)sum05 - op, 1));
                datos2.Iva = Convert.ToString(0);
                fac.datos2.Add(datos2);
            }
            
            Iva19.Add(5);
            datos.NumFacVenta = cod_venta.Text;
            datos.NomEmpleado = cb_vendedor.Text;
            datos.Fecha = dateTimePicker1.Text;
            datos.Cliente = cb_cliente.Text;
            datos.SubTotal = textBox6.Text;
            datos.Descuento = txt_descuento.Text;
            datos.Valfinal = txt_total.Text;
            datos.Hora=DateTime.Now.ToString("hh:mm:ss");
            fac.datos.Add(datos);
            fac.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.llama_print();

        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void txt_total_MouseHover(object sender, EventArgs e)
        {
            //txt_descuento.TextChanged = false;
            double descuento = 0;
            double probando = 0;

            if (txt_total.Text != "" && textBox6.Text != "")
            {
                probando = System.Convert.ToDouble(textBox6.Text);
                descuento = System.Convert.ToDouble(txt_total.Text);
                double Op = (((probando - descuento) * 100) / probando);
                txt_descuento.Text = System.Convert.ToString(Math.Round(Op, 0));
            }
        }

        private void txt_total_Enter(object sender, EventArgs e)
        {
            //txt_descuento.TextChanged = false;
            double descuento = 0;
            double probando = 0;

            if (txt_total.Text != "" && textBox6.Text != "")
            {
                probando = System.Convert.ToDouble(textBox6.Text);
                descuento = System.Convert.ToDouble(txt_total.Text);
                double Op = (((probando - descuento) * 100) / probando);
                txt_descuento.Text = System.Convert.ToString(Math.Round(Op, 0));
            }
        }

        private void txt_total_MouseDown(object sender, MouseEventArgs e)
        {
            //txt_descuento.TextChanged = false;
            double descuento = 0;
            double probando = 0;

            if (txt_total.Text != "" && textBox6.Text != "")
            {
                probando = System.Convert.ToDouble(textBox6.Text);
                descuento = System.Convert.ToDouble(txt_total.Text);
                double Op = (((probando - descuento) * 100) / probando);
                txt_descuento.Text = System.Convert.ToString(Math.Round(Op, 0));
            }
        }

        private void txt_total_MouseLeave(object sender, EventArgs e)
        {
            //txt_descuento.TextChanged = false;
            double descuento = 0;
            double probando = 0;

            if (txt_total.Text != "" && textBox6.Text != "")
            {
                probando = System.Convert.ToDouble(textBox6.Text);
                descuento = System.Convert.ToDouble(txt_total.Text);
                double Op = (((probando - descuento) * 100) / probando);
                txt_descuento.Text = System.Convert.ToString(Math.Round(Op, 0));
            }
        }

        private void txt_recibido_MouseLeave(object sender, EventArgs e)
        {
            //double recibido = 0;
            //double total = 0;
            //double operacion = 0;
            //if (txt_total.Text != "")
            //{
            //    total= System.Convert.ToDouble(txt_total.Text);
            //    recibido = System.Convert.ToDouble(txt_recibido.Text);
            //    operacion = recibido - total;
            //    txt_cambio.Text = System.Convert.ToString(Math.Round(operacion, 0));
            //}
        }

        private void txt_recibido_MouseUp(object sender, MouseEventArgs e)
        {
            //double recibido = 0;
            //double total = 0;
            //double operacion = 0;
            //if (txt_total.Text != "")
            //{
            //    total = System.Convert.ToDouble(txt_total.Text);
            //    recibido = System.Convert.ToDouble(txt_recibido.Text);
            //    operacion = recibido - total;
            //    txt_cambio.Text = System.Convert.ToString(Math.Round(operacion, 0));
            //}
        }

        private void txt_recibido_TextChanged(object sender, EventArgs e)
        {
            double recibido = 0;
            double total = 0;
            double operacion = 0;
            if (txt_total.Text != "" && txt_recibido.Text != "")
            {
                total = System.Convert.ToDouble(txt_total.Text);
                recibido = System.Convert.ToDouble(txt_recibido.Text);
                operacion = recibido - total;
                txt_cambio.Text = System.Convert.ToString(Math.Round(operacion, 0));
            }
            else if (txt_recibido.Text == "")
            {
                txt_cambio.Text = "";
                
            }
        }
    }
    
}
