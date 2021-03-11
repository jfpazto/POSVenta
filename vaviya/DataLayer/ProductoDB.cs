using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductoDB
    {
        public DataTable ObtieneProductos()
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("Trae_todos_poductos", conn);
                

                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void Insertar_Productos(string ProdCod, string ProdNombre,float precio, float costo, int iva,float precioIva)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                
                SqlCommand comando = new SqlCommand("Actualiza_Productos", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Prod_Cod", ProdCod);
                comando.Parameters.AddWithValue("@Prod_Nombre", ProdNombre);
                comando.Parameters.AddWithValue("@Prod_Precio", precio);
                comando.Parameters.AddWithValue("@Prod_Costo", costo);
                comando.Parameters.AddWithValue("@Prod_Iva", iva);
                comando.Parameters.AddWithValue("@ProdPrecioIva", precioIva);
                comando.ExecuteNonQuery();
                
            }


        }
        public void elimina_productos(int ProdId)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();

                SqlCommand comando = new SqlCommand("elimina_productos", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Prod_id", ProdId);

                comando.ExecuteNonQuery();

            }


        }
        public DataTable ObtieneProductosInventario(string prodNombre)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("AutoRellenaProductos", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ProdNombre", prodNombre);

                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable ObtienecodigosInventario(string prodCod)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("AutoRellenaProductosCodigo", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ProdCod", prodCod);

                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


    }
}
