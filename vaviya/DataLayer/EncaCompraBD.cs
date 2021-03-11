using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataLayer
{
    public class EncaCompraBD
    {
        public string Obtiene_registro_compra()
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand revisa = new SqlCommand("Cod_compra_tra", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                string valor_re = revisa.ExecuteScalar().ToString();
                return valor_re;
            }
        }
        public void Inserta_encabezado_compra( int EncCompProveedorId,int EncCompRecibidoPor,DateTime EncCompFecha, string EncCompObservaciones, string EncCompValorTotal, char valPrestamo)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                //Inserta los valores en el encabezado compra
                SqlCommand inserta_enca = new SqlCommand("inserta_Encabezado", conn);
                inserta_enca.CommandType = CommandType.StoredProcedure;
                inserta_enca.Parameters.Add("@EncCompProveedorId", SqlDbType.Int).Value = EncCompProveedorId;
                inserta_enca.Parameters.Add("@EncCompRecibidoPor", SqlDbType.Int).Value = EncCompRecibidoPor;
                inserta_enca.Parameters.Add("@EncCompFecha", SqlDbType.DateTime).Value = EncCompFecha;
                inserta_enca.Parameters.Add("@EncCompObservaciones", SqlDbType.VarChar).Value = EncCompObservaciones;
                inserta_enca.Parameters.Add("@EncCompValorTotal", SqlDbType.Float).Value = System.Convert.ToSingle(EncCompValorTotal);
                inserta_enca.Parameters.Add("@Prestamo", SqlDbType.Char).Value = valPrestamo;
                inserta_enca.ExecuteNonQuery();
            }
        }
        public string Consultaid_encabezado_compra(string id)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                //Consulta el id de cada producto
                SqlCommand soloid = new SqlCommand("Consulta_soloid_Producto", conn);
                soloid.CommandType = CommandType.StoredProcedure;
                soloid.Parameters.Add("@Prod_Cod", SqlDbType.VarChar, 50);
                soloid.Parameters["@Prod_Cod"].Value = id;
                string valor_re = soloid.ExecuteScalar().ToString();
                return valor_re;
            }
        }
        public void Guarda_movimientos(DateTime fecha,int Prodid,int cantidad,float valor_uni,float valo_tot,int movenccompra,char valPrestamo)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {

                try
                {
                    conn.Open();
                    SqlCommand revisa = new SqlCommand("Inserta_movimientos_p", conn);
                    revisa.CommandType = CommandType.StoredProcedure;
                    revisa.Parameters.Add("@MovFecha", SqlDbType.DateTime).Value = fecha;
                    revisa.Parameters.Add("@MovProdId", SqlDbType.Int).Value = Prodid;
                    revisa.Parameters.Add("@MovProdCantidad", SqlDbType.Int).Value = cantidad;
                    revisa.Parameters.Add("@MovProdValorUnitario", SqlDbType.Float).Value = valor_uni;
                    revisa.Parameters.Add("@MovProdValorTotal", SqlDbType.Float).Value = valo_tot;
                    revisa.Parameters.Add("@MovProdTipoMov", SqlDbType.VarChar).Value = "Compra";
                    revisa.Parameters.Add("@MovEncCompra", SqlDbType.Int).Value = movenccompra;
                    revisa.Parameters.Add("@Prestamo", SqlDbType.Char).Value = valPrestamo;
                    revisa.ExecuteNonQuery();
                    //AQI
                   
                }
                catch
                {
                    string message = "Cantidad Insuficiente";
                    string title = "VAVIYA";
                }

            }
        }
        public string busca_existe(string resul)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand revisa = new SqlCommand("nombre_or", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                revisa.Parameters.Add("@ProdNombre", SqlDbType.VarChar, 250);
                revisa.Parameters["@ProdNombre"].Value = resul;
                string valor_re = revisa.ExecuteScalar().ToString();
                return valor_re;
            }

        }
        public string busca_existeCodigo(string resul)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand revisa = new SqlCommand("existeProdCod", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                revisa.Parameters.Add("@ProdCod", SqlDbType.VarChar, 50);
                revisa.Parameters["@ProdCod"].Value = resul;
                string valor_re = revisa.ExecuteScalar().ToString();
                return valor_re;
            }

        }
        public string busca_nombre(string resul)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("Obtiene_Nombre", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ProdNombre", SqlDbType.VarChar, 250);
                comando.Parameters["@ProdNombre"].Value = resul;
                string getValue = comando.ExecuteScalar().ToString();
                return getValue;
            }

        }

        public string busca_nombreCod(string resul)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("Obtiene_nombreCod", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ProdCod", SqlDbType.VarChar, 50);
                comando.Parameters["@ProdCod"].Value = resul;
                string getValue = comando.ExecuteScalar().ToString();
                return getValue;
            }

        }
        public string busca_costo(string resul)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("Consulta_Costo_Productos", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@Prod_Cod", SqlDbType.VarChar, 50);
                consulta_precio.Parameters["@Prod_Cod"].Value = resul;
                string valor_escalar = consulta_precio.ExecuteScalar().ToString();
                return valor_escalar;
            }

        }
        public string consulta_numero_persona(string rol,string nombre,string apellido)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("extrae_el_numero_tipo", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@Rol", SqlDbType.VarChar, 100);
                consulta_precio.Parameters.Add("@Nombre", SqlDbType.VarChar, 100);
                consulta_precio.Parameters.Add("@Apellido", SqlDbType.VarChar, 100);
                consulta_precio.Parameters["@Rol"].Value = rol;
                consulta_precio.Parameters["@Nombre"].Value = nombre;
                consulta_precio.Parameters["@Apellido"].Value = apellido;
                string valor_escalar = consulta_precio.ExecuteScalar().ToString();
                return valor_escalar;
            }

        }
        public DataTable obtiene_nom_ape_persona1(string tipo)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                SqlDataReader dl;
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("obtiene_nom_ape_personas", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@PerRol", SqlDbType.VarChar, 50);
                consulta_precio.Parameters["@PerRol"].Value = tipo;
                dl = consulta_precio.ExecuteReader();
                DataTable tabla = new DataTable();

                //columnas

                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Apellido");
                while (dl.Read())
                {
                    tabla.Rows.Add(dl["PerNombre"].ToString(), dl["PerApellidos"].ToString());
                }
                return tabla;
            }

        }
        public DataTable obtiene_una_nueva_factura(int identificar)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                SqlDataReader dl;
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("consulta_encabezado_factura", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@Ventaid", SqlDbType.Int);
                consulta_precio.Parameters["@Ventaid"].Value = identificar;
                dl = consulta_precio.ExecuteReader();
                DataTable tabla = new DataTable();

                //columnas

                tabla.Columns.Add("IdVenta");
                tabla.Columns.Add("IdProveedor");
                tabla.Columns.Add("IdEmpleado");
                tabla.Columns.Add("Fecha");
                tabla.Columns.Add("Observaciones");
                tabla.Columns.Add("Total");
                while (dl.Read())
                {
                    tabla.Rows.Add(dl["EncCompId"].ToString(), dl["EncCompProveedorId"].ToString(), dl["EncCompRecibidoPor"].ToString(), dl["EncCompFecha"].ToString(), dl["EncCompObservaciones"].ToString(), dl["EncCompValorTotal"].ToString());
                }
                return tabla;
            }

        }
        public DataTable nombre_y_apellidos(int identificador)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                SqlDataReader dl;
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("nombre_apellido", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@PerId", SqlDbType.Int);
                consulta_precio.Parameters["@PerId"].Value = identificador;
                dl = consulta_precio.ExecuteReader();
                DataTable tabla = new DataTable();

                //columnas

                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Apellido");
                while (dl.Read())
                {
                    tabla.Rows.Add(dl["PerNombre"].ToString(), dl["PerApellidos"].ToString());
                }
                return tabla;
            }

        }
        public DataTable mov_compra(int identificador)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                SqlDataReader dl;
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("Consulta_mov_compra", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@MovEncCompra", SqlDbType.Int);
                consulta_precio.Parameters["@MovEncCompra"].Value = identificador;
                dl = consulta_precio.ExecuteReader();
                DataTable tabla = new DataTable();

                //columnas

                tabla.Columns.Add("ProdId");
                tabla.Columns.Add("cantidad");
                tabla.Columns.Add("valor_unitario");
                tabla.Columns.Add("valor_total");
                while (dl.Read())
                {
                    tabla.Rows.Add(dl["MovProdId"].ToString(), dl["MovProdCantidad"].ToString(), dl["MovProdValorUnitario"].ToString(), dl["MovProdValorTotal"].ToString());
                }
                return tabla;
            }


        }
        public DataTable detalle_producto(int identificador)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                SqlDataReader dl;
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("Consulta_detalle_producto", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@ProdId", SqlDbType.Int);
                consulta_precio.Parameters["@ProdId"].Value = identificador;
                dl = consulta_precio.ExecuteReader();
                DataTable tabla = new DataTable();

                //columnas

                tabla.Columns.Add("Codigo");
                tabla.Columns.Add("Nombre");
                while (dl.Read())
                {
                    tabla.Rows.Add(dl["ProdCod"].ToString(), dl["ProdNombre"].ToString());
                }
                return tabla;
            }


        }
        public void Inserta_cantidad(int cantidad,int IdProducto)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand revisa = new SqlCommand("Inserta_cantidad_producto", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                revisa.Parameters.Add("@ProdCantidad", SqlDbType.Int).Value = cantidad;
                revisa.Parameters.Add("@ProdId", SqlDbType.Int).Value = IdProducto;

                revisa.ExecuteNonQuery();

            }
        }


    }
}
