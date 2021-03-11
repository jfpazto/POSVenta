using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EncCompraBL 
    {
        EncaCompraBD datos = new EncaCompraBD();

        public string LLama_registro_compra()
        {
            string valor;
            valor = datos.Obtiene_registro_compra();
            return valor;
        }
        public void LLama_inserta_encabezado(int EncCompProveedorId, int EncCompRecibidoPor, DateTime EncCompFecha, string EncCompObservaciones, string EncCompValorTotal, char valPrestamo)
        {
            datos.Inserta_encabezado_compra(EncCompProveedorId,EncCompRecibidoPor,EncCompFecha,EncCompObservaciones,EncCompValorTotal, valPrestamo);
        }
        public string Obtiene_id(string id)
        {
            string resultado;
            resultado=datos.Consultaid_encabezado_compra(id);
            return resultado;
        }
        public void LLama_guarda_movimientos(DateTime fecha, int Prodid, int cantidad, float valor_uni, float valo_tot, int movenccompra,char valPrestamo)
        {
            datos.Guarda_movimientos(fecha, Prodid, cantidad, valor_uni, valo_tot, movenccompra,valPrestamo);
        }

        public string LLama_siexiste(string resul)
        {
            string resultado = datos.busca_existe(resul);
            return resultado;

        }
        public string LLama_siexisteCodido(string resul)
        {
            string resultado = datos.busca_existeCodigo(resul);
            return resultado;

        }

        
        public string LLama_nombre(string resul)
        {
            string resultado = datos.busca_nombre(resul);
            return resultado;
        }
        public string LLama_nombreCod(string resul)
        {
            string resultado = datos.busca_nombreCod(resul);
            return resultado;
        }
        public string LLama_costo(string resul)
        {
            string resultado = datos.busca_costo(resul);
            return resultado;
        }
        public string obtiene_identi_persona(string rol, string nombre, string apellido)
        {
            string resultado = datos.consulta_numero_persona(rol,nombre,apellido);
            return resultado;
        }
        public DataTable obtiene_nombres_persona(string tipo)
        {

              return(datos.obtiene_nom_ape_persona1(tipo));

        }
        public DataTable obtiene_datos_encabezado(int identificar)
        {

            return (datos.obtiene_una_nueva_factura(identificar));

        }
        public DataTable inserta_nombre_apellido(int identificador)
        {

            return (datos.nombre_y_apellidos(identificador));

        }
        public DataTable trae_mov_compra(int identificador)
        {

            return (datos.mov_compra(identificador));

        }
        public DataTable trae_detalle_prod(int identificador)
        {

            return (datos.detalle_producto(identificador));

        }
        public void LLama_Inserta_cantidad(int cantidad,int IdProducto)
        {
            datos.Inserta_cantidad(cantidad,IdProducto);
            
        }
    }
}
