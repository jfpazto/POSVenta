using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EncaVentaBD
    {
        public string Obtiene_registro_venta()
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand revisa = new SqlCommand("Cod_venta_tra", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                string valor_re = revisa.ExecuteScalar().ToString();
                return valor_re;
            }
        }
        public void Inserta_encabezado_venta(int EncVentaId,int EncVentaClienteId, DateTime EncVentaFecha,int EncVentaVendedorId, string EncVentaObservaciones, string EncVentaValorTotal, char valPrestamo)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand inserta_enca = new SqlCommand("inserta_enca_venta", conn);
                inserta_enca.CommandType = CommandType.StoredProcedure;
                inserta_enca.Parameters.Add("@EncVentaId", SqlDbType.Int).Value = EncVentaId;
                inserta_enca.Parameters.Add("@EncVentaClienteId", SqlDbType.Int).Value = EncVentaClienteId;
                inserta_enca.Parameters.Add("@EncVentaFecha", SqlDbType.DateTime).Value = EncVentaFecha;
                inserta_enca.Parameters.Add("@EncVentaVendedorId", SqlDbType.Int).Value = EncVentaVendedorId;
                inserta_enca.Parameters.Add("@EncVentaObservaciones", SqlDbType.VarChar).Value = EncVentaObservaciones;
                inserta_enca.Parameters.Add("@EncVentaValorTotal", SqlDbType.Float).Value = System.Convert.ToSingle(EncVentaValorTotal);
                inserta_enca.Parameters.Add("@Prestamo", SqlDbType.Char).Value = valPrestamo;
                inserta_enca.ExecuteNonQuery();
            }
        }
        public string Consultaid_encabezado_venta(string id)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand soloid = new SqlCommand("Consulta_soloid_Producto", conn);
                soloid.CommandType = CommandType.StoredProcedure;
                soloid.Parameters.Add("@Prod_Cod", SqlDbType.VarChar, 50);
                soloid.Parameters["@Prod_Cod"].Value = id;
                string valor_re = soloid.ExecuteScalar().ToString();
                return valor_re;
            }
        }
        public void Guarda_movimientos(DateTime fecha, int Prodid, int cantidad, float valor_uni, float valo_tot, int movencventa, int movprocentajeventa,int iva, char valPrestamo)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand revisa = new SqlCommand("Inserta_movimientos_venta", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                revisa.Parameters.Add("@MovFecha", SqlDbType.DateTime).Value = fecha;
                revisa.Parameters.Add("@MovProdId", SqlDbType.Int).Value = Prodid;
                revisa.Parameters.Add("@MovProdCantidad", SqlDbType.Int).Value = cantidad;
                revisa.Parameters.Add("@MovProdValorUnitario", SqlDbType.Float).Value = valor_uni;
                revisa.Parameters.Add("@MovProdValorTotal", SqlDbType.Float).Value = valo_tot;
                revisa.Parameters.Add("@MovProdTipoMov", SqlDbType.VarChar).Value = "Venta";
                revisa.Parameters.Add("@MovEncVenta", SqlDbType.Int).Value = movencventa;
                revisa.Parameters.Add("@MovPorcVenta", SqlDbType.Int).Value = movprocentajeventa;
                revisa.Parameters.Add("@MovIvaProd", SqlDbType.Int).Value = iva;
                revisa.Parameters.Add("@Prestamo", SqlDbType.Char).Value = valPrestamo;
                revisa.ExecuteNonQuery();
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
                comando.Parameters.Add("@ProdNombre", SqlDbType.VarChar, 350);
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
                SqlCommand consulta_precio = new SqlCommand("Consulta_Precio_Productos", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@ProdNombre", SqlDbType.VarChar, 250);
                consulta_precio.Parameters["@ProdNombre"].Value = resul;
                string valor_escalar = consulta_precio.ExecuteScalar().ToString();
                return valor_escalar;
            }

        }
        public string consulta_numero_persona(string rol, string nombre, string apellido)
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
                SqlCommand consulta_precio = new SqlCommand("consulta_enca_venta", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@Ventaid", SqlDbType.Int);
                consulta_precio.Parameters["@Ventaid"].Value = identificar;
                dl = consulta_precio.ExecuteReader();
                DataTable tabla = new DataTable();

                //columnas

                tabla.Columns.Add("IdVenta");
                tabla.Columns.Add("Cliente");
                tabla.Columns.Add("Fecha");
                tabla.Columns.Add("Vendedor");
                tabla.Columns.Add("Observaciones");
                tabla.Columns.Add("Total");
                tabla.Columns.Add("Prestamo");
                while (dl.Read())
                {
                    tabla.Rows.Add(dl["EncVentaId"].ToString(), dl["EncVentaClienteId"].ToString(), dl["EncVentaFecha"].ToString(), dl["EncVentaVendedorId"].ToString(), dl["EncVentaObservaciones"].ToString(), dl["EncVentaValorTotal"].ToString(), dl["Prestamo"].ToString());
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
        public DataTable mov_venta(int identificador)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                SqlDataReader dl;
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("Consulta_mov_venta", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@MovEncVenta", SqlDbType.Int);
                consulta_precio.Parameters["@MovEncVenta"].Value = identificador;
                dl = consulta_precio.ExecuteReader();
                DataTable tabla = new DataTable();

                //columnas

                tabla.Columns.Add("ProdId");
                tabla.Columns.Add("cantidad");
                tabla.Columns.Add("valor_unitario");
                tabla.Columns.Add("valor_total");
                tabla.Columns.Add("valoriva");
                tabla.Columns.Add("PorcProducto");
                while (dl.Read())
                {
                    tabla.Rows.Add(dl["MovProdId"].ToString(), dl["MovProdCantidad"].ToString(), dl["MovProdValorUnitario"].ToString(), dl["MovProdValorTotal"].ToString(), dl["IvaProd"].ToString(), dl["PorcentajeDesc"].ToString());
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
        public string consulta_cantidad_producto(int idproducto)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand consulta_producto = new SqlCommand("Trae_cantidad_producto", conn);
                consulta_producto.CommandType = CommandType.StoredProcedure;
                consulta_producto.Parameters.Add("@MovProdId", SqlDbType.Int);
                consulta_producto.Parameters["@MovProdId"].Value = idproducto;

                string valor_escalar = consulta_producto.ExecuteScalar().ToString();
                return valor_escalar;
            }

        }
        public int VerificaExisteVenta(int idVenta)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("VerificaExisteVenta", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@MovEncVenta", SqlDbType.Int);
                consulta_precio.Parameters["@MovEncVenta"].Value = idVenta;
                int valor_escalar = System.Convert.ToInt32(consulta_precio.ExecuteScalar());
                return valor_escalar;
            }

        }
        public void ActualizaCantProd(int idVenta, int prodId)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("ActualizaCantidadesProd", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@MovEncVenta", SqlDbType.Int);
                consulta_precio.Parameters["@MovEncVenta"].Value = idVenta;
                consulta_precio.Parameters.Add("@MovProdId", SqlDbType.Int);
                consulta_precio.Parameters["@MovProdId"].Value = prodId;
                consulta_precio.ExecuteNonQuery();
                
            }

        }
        public void Actualiza_cantidad(int cantidad, int IdProducto)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand revisa = new SqlCommand("cantidad_producto_venta", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                revisa.Parameters.Add("@ProdCantidad", SqlDbType.Int).Value = cantidad;
                revisa.Parameters.Add("@ProdId", SqlDbType.Int).Value = IdProducto;

                revisa.ExecuteNonQuery();

            }
        }
        public void eliminaMovProd(int Idventa, int IdProducto)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand revisa = new SqlCommand("eliminaMovProd", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                revisa.Parameters.Add("@MovEncVenta", SqlDbType.Int).Value = Idventa;
                revisa.Parameters.Add("@MovProdId", SqlDbType.Int).Value = IdProducto;

                revisa.ExecuteNonQuery();

            }
        }
        public string ConsulProdMov(int Idventa,int IdProducto)
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand soloid = new SqlCommand("consultaExisteProMov", conn);
                soloid.CommandType = CommandType.StoredProcedure;
                soloid.Parameters.Add("@MovEncVenta", SqlDbType.Int).Value = Idventa;
                soloid.Parameters.Add("@MovProdId", SqlDbType.Int).Value = IdProducto;
                string valor_re = soloid.ExecuteScalar().ToString();
                return valor_re;
            }
        }
        public string busca_iva(string resul)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand consulta_precio = new SqlCommand("consulta_ivaProd", conn);
                consulta_precio.CommandType = CommandType.StoredProcedure;
                consulta_precio.Parameters.Add("@ProdNombre", SqlDbType.VarChar, 250);
                consulta_precio.Parameters["@ProdNombre"].Value = resul;
                string valor_escalar = consulta_precio.ExecuteScalar().ToString();
                return valor_escalar;
            }

        }
        public DataTable ObtieneFactura(string prodNombre, string clientenombre)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("consultaFacturaEficiente", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ProdNombres", prodNombre);
                comando.Parameters.AddWithValue("@ProdNombreCliente", clientenombre);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
