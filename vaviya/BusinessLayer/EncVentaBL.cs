using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EncVentaBL
    {
        EncaVentaBD datos = new EncaVentaBD();
        public string test1 = string.Empty;
        public string LLama_registro_venta()
        {
            string valor;
            valor = datos.Obtiene_registro_venta();
            return valor;
        }
        public void LLama_inserta_encabezado(int EncVentaId,int EncVentaClienteId, DateTime EncVentaFecha, int EncVentaVendedorId, string EncVentaObservaciones, string EncVentaValorTotal, char valPrestamo)
        {
            datos.Inserta_encabezado_venta(EncVentaId,EncVentaClienteId,EncVentaFecha,EncVentaVendedorId,EncVentaObservaciones,EncVentaValorTotal, valPrestamo);
        }
        public string Obtiene_id(string id)
        {
            string resultado;
            resultado = datos.Consultaid_encabezado_venta(id);
            return resultado;
        }
        public void LLama_guarda_movimientos(DateTime fecha, int Prodid, int cantidad, float valor_uni, float valo_tot, int movencventa, int movprocentajeventa,int Iva,char valPrestamo)
        {
            datos.Guarda_movimientos(fecha, Prodid, cantidad, valor_uni, valo_tot, movencventa, movprocentajeventa,Iva,valPrestamo);
        }
        public string LLama_siexiste(string resul)
        {
            string resultado = datos.busca_existe(resul);
            return resultado;

        }
        public int VerificaIdVenta(int resul)
        {
            int resultado = datos.VerificaExisteVenta(resul);
            return resultado;

        }

        public void ActuaCanProd(int idventa,int prodid)
        {
            datos.ActualizaCantProd(idventa,prodid);
            

        }
        public string LLama_siexisteCodido(string resul)
        {
            string resultado = datos.busca_existeCodigo(resul);
            return resultado;

        }
        public string LLama_nombreCod(string resul)
        {
            string resultado = datos.busca_nombreCod(resul);
            return resultado;
        }

        public string LLama_nombre(string resul)
        {
            string resultado = datos.busca_nombre(resul);
            return resultado;
        }
        public string LLama_costo(string resul)
        {
            string resultado = datos.busca_costo(resul);
            return resultado;
        }
        public string LLama_iva(string resul)
        {
            string resultado = datos.busca_iva(resul);
            return resultado;
        }
        public string obtiene_identi_persona(string rol, string nombre, string apellido)
        {
            string resultado = datos.consulta_numero_persona(rol, nombre, apellido);
            return resultado;
        }
        public DataTable obtiene_nombres_persona(string tipo)
        {

            return (datos.obtiene_nom_ape_persona1(tipo));

        }
        public DataTable obtiene_datos_encabezado(int identificar)
        {

            return (datos.obtiene_una_nueva_factura(identificar));

        }
        public DataTable inserta_nombre_apellido(int identificador)
        {

            return (datos.nombre_y_apellidos(identificador));

        }
        public DataTable trae_mov_venta(int identificador)
        {

            return (datos.mov_venta(identificador));

        }
        public DataTable trae_detalle_prod(int identificador)
        {

            return (datos.detalle_producto(identificador));

        }
        public string obtiene_cantidad_producto(int idproducto)
        {
            string resultado = datos.consulta_cantidad_producto(idproducto);
            return resultado;
        }
        public void LLama_Inserta_cantidad(int cantidad, int IdProducto)
        {
            datos.Actualiza_cantidad(cantidad, IdProducto);

        }
        public void EliminaMovProd(int Idventa, int IdProducto)
        {
            datos.eliminaMovProd(Idventa, IdProducto);

        }
        public string consulta_prodMovimiento(int Idventa, int IdProducto)
        {
            string resultado = datos.ConsulProdMov(Idventa,IdProducto);
            return resultado;
        }

        public DataTable ObtenerFacturas(string prodNombre,string nomCliente)
        {
            DataTable dt = null;
            try
            {
                dt = datos.ObtieneFactura(prodNombre,nomCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

    }
}
