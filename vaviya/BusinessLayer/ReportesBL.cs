using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ReportesBL
    {
        ReportesBd dataProducto = new ReportesBd();
        public DataTable ObtenerProductos()
        {
            DataTable dt = null;
            try
            {
                dt = dataProducto.Productos_vencidos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Consulta_fecha(string Fecha_ini,string Fecha_fin)
        {
            DataTable dt = null;
            try
            {
                dt = dataProducto.Ventas_fecha(Fecha_ini,Fecha_fin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable Consulta_compra_fecha(string Fecha_ini, string Fecha_fin)
        {
            DataTable dt = null;
            try
            {
                dt = dataProducto.Compras_fecha(Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable retfacSimple(string Fecha_ini, string Fecha_fin)
        {
            DataTable dt = null;
            try
            {
                dt = dataProducto.facSimple(Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable retfacMovi(string Fecha_ini, string Fecha_fin)
        {
            DataTable dt = null;
            try
            {
                dt = dataProducto.facMovi(Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable retfacPrestamos(string Fecha_ini, string Fecha_fin)
        {
            DataTable dt = null;
            try
            {
                dt = dataProducto.facPrestamos(Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }

}
