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
    public partial class Contabilidad : Form
    {


        ReportesBL reportes_info = new ReportesBL();
        public Contabilidad()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkPrestamos.Checked = false;
                string Fecha_ini = System.Convert.ToString(date1.Value.Date.ToString("yyyy/MM/dd"));
                string Fecha_fin = System.Convert.ToString(date2.Value.Date.ToString("yyyy/MM/dd"));
                var dt = reportes_info.retfacSimple(Fecha_ini, Fecha_fin);
                dataGrid1.DataSource = dt;
        
            }

        }

        private void Contabilidad_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportarDatos(dataGrid1);
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkPrestamos.Checked = false;
                checkBox1.Checked = false;
                string Fecha_ini = System.Convert.ToString(date1.Value.Date.ToString("yyyy/MM/dd"));
                string Fecha_fin = System.Convert.ToString(date2.Value.Date.ToString("yyyy/MM/dd"));
                var dt = reportes_info.retfacMovi(Fecha_ini, Fecha_fin);
                dataGrid1.DataSource = dt;

            }

            this.precioBaseUnitario();
            


        }

        public void precioBaseUnitario()
        {
            foreach (DataGridViewRow row in dataGrid1.Rows)
            {

                if (row.Cells[1].Value != null)
                {
                    if (row.Cells["Descuento"].Value != null)
                    {
                        try
                        {

                            double des = System.Convert.ToInt32(row.Cells["Descuento"].Value.ToString());
                            int cantidad = System.Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                            int val_unitario = System.Convert.ToInt32(row.Cells["ValorUnitario"].Value.ToString());
                            double operacion = (val_unitario * cantidad * (des / (double)100));

                            row.Cells["ValorDescuento"].Value = operacion.ToString();
                        }

                        catch
                        {
                            row.Cells["Descuento"].Value = "0";
                            double des = 0;
                            int cantidad = System.Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                            int val_unitario = System.Convert.ToInt32(row.Cells["ValorUnitario"].Value.ToString());
                            double operacion = (val_unitario * cantidad * (des / (double)100));

                            row.Cells["ValorDescuento"].Value = operacion.ToString();
                        }

                    }





                }
                if (row.Cells["ValorTotal"].Value != null)
                {
                    try
                    {
                        
                        double des = System.Convert.ToDouble(row.Cells["ValorDescuento"].Value.ToString());
                        double cantidad = System.Convert.ToDouble(row.Cells["Cantidad"].Value.ToString());
                        double val_unitario = System.Convert.ToDouble(row.Cells["ValorUnitario"].Value.ToString());
                        double valoresTotal = cantidad * val_unitario - des;
                        row.Cells["ValorTotal"].Value = valoresTotal;
                    }

                    catch
                    {
                        MessageBox.Show("Error, vuelva a cargar");
                    }

                }

                if (row.Cells[1].Value != null)
                {
                    if (row.Cells["PrecioBase"].Value != null)
                    {
                        try
                        {

                            double iva = System.Convert.ToDouble(row.Cells["IVA"].Value.ToString());
                            double cantidad = System.Convert.ToDouble(row.Cells["Cantidad"].Value.ToString());
                            double val_total = System.Convert.ToDouble(row.Cells["ValorTotal"].Value.ToString());
                            double valTotal = Math.Round((val_total/cantidad) / ((iva+100)/(double)100));
                            double base_total = 0;
                            row.Cells["PrecioBase"].Value = valTotal.ToString();
                            if (valTotal > 0)
                            {
                                base_total = System.Convert.ToInt32(Math.Round(valTotal * cantidad));

                                row.Cells["PrecioTotalBase"].Value = base_total;
                            }
                            if (row.Cells["Tipo"].Value.ToString() == "V")
                            {
                                double costo_unitario = System.Convert.ToDouble(row.Cells["CostoRealProducto"].Value.ToString());
                                double costoreal = Math.Round((costo_unitario / ((iva + 100) / (double)100)) * cantidad);
                                double iva_compra = Math.Round(costoreal* (double)(iva/100));
                                row.Cells["IvaCompra"].Value = iva_compra;
                                
                                

                                double iva_venta = Math.Round(base_total * (iva / 100));
                                row.Cells["IvaVenta"].Value = iva_venta;




                                row.Cells["CostoRealProducto"].Value = costoreal;
                                row.Cells["ValorInventario"].Value = 0;


                                double utilidad = val_total-(iva_venta+iva_compra+costoreal);
                                row.Cells["Utilidad"].Value = utilidad;
                            }
                            if (row.Cells["Tipo"].Value.ToString() == "C")
                            {
                                
                                row.Cells["IvaVenta"].Value = 0;

                                double iva_compra = Math.Round(base_total * (iva / 100));
                                row.Cells["IvaCompra"].Value = iva_compra;
                                row.Cells["CostoRealProducto"].Value = 0;

                                row.Cells["ValorInventario"].Value = base_total;
                                row.Cells["Utilidad"].Value = 0;
                            }

                        }

                        catch
                        {
                            row.Cells["IVA"].Value = "19";
                            double iva = 19;
                            double cantidad = System.Convert.ToDouble(row.Cells["Cantidad"].Value.ToString());
                            double val_total = System.Convert.ToDouble(row.Cells["ValorTotal"].Value.ToString());
                            double valTotal = Math.Round((val_total / cantidad) / ((iva+100) / (double)100));
                            double base_total=0;
                            row.Cells["PrecioBase"].Value = valTotal.ToString();
                            if (valTotal > 0)
                            {
                                base_total = System.Convert.ToInt32(Math.Round(valTotal * cantidad));

                                row.Cells["PrecioTotalBase"].Value = base_total;
                            }
                            if (row.Cells["Tipo"].Value.ToString() == "V")
                            {
                                double costo_unitario = System.Convert.ToDouble(row.Cells["CostoRealProducto"].Value.ToString());
                                double costoreal = Math.Round((costo_unitario / ((iva + 100) / (double)100)) * cantidad);
                                double iva_compra = Math.Round(costoreal * (double)(iva / 100));
                                row.Cells["IvaCompra"].Value = iva_compra;

                                double iva_venta = Math.Round(base_total* (iva / 100));
                                row.Cells["IvaVenta"].Value = iva_venta;


                                row.Cells["CostoRealProducto"].Value = costoreal;
                                row.Cells["ValorInventario"].Value = 0;


                                double utilidad = val_total - (iva_venta + iva_compra + costoreal);
                                row.Cells["Utilidad"].Value = utilidad;
                            }
                            if (row.Cells["Tipo"].Value.ToString() == "C")
                            {
                                
                                row.Cells["IvaVenta"].Value = 0;

                                double iva_compra = Math.Round(base_total * (iva / 100));
                                row.Cells["IvaCompra"].Value = iva_compra;

                                row.Cells["CostoRealProducto"].Value = 0;
                                row.Cells["ValorInventario"].Value = base_total;
                                row.Cells["Utilidad"].Value = 0;
                            }


                        }


                    }

                }


            }
        }


        private void checkPrestamos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrestamos.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                string Fecha_ini = System.Convert.ToString(date1.Value.Date.ToString("yyyy/MM/dd"));
                string Fecha_fin = System.Convert.ToString(date2.Value.Date.ToString("yyyy/MM/dd"));
                var dt = reportes_info.retfacPrestamos(Fecha_ini, Fecha_fin);
                dataGrid1.DataSource = dt;

            }

        }
    }
}
