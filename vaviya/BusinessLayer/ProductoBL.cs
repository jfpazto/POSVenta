using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductoBL
    {
        ProductoDB dataProducto = new ProductoDB();

        public DataTable ObtenerProductos()
        {
            DataTable dt = null;
            try
            {
                dt = dataProducto.ObtieneProductos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
       
        public DataTable ObtenerProductosInv(string prodNombre)
        {
            DataTable dt = null;
            try
            {
                dt = dataProducto.ObtieneProductosInventario(prodNombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable ObtenerProductosCod(string prodNombre)
        {
            DataTable dt = null;
            try
            {
                dt = dataProducto.ObtienecodigosInventario(prodNombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public void Insertar_Productos_llama(string ProdCod, string ProdNombre, float precio, float costo,int iva,float precioIva)
        {
            dataProducto.Insertar_Productos(ProdCod, ProdNombre, precio, costo,iva,precioIva);
            
        }
        public void LLama_eli_productos(int ProdId)
        {
            dataProducto.elimina_productos(ProdId);

        }
    }

}
