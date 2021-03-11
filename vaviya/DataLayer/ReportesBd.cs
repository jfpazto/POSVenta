using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ReportesBd
    {
        public DataTable Productos_vencidos()
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("Productos_a_vencer", conn);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Ventas_fecha(string Fecha_ini,string Fecha_fin )
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("consulta_venta_fecha", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Fecha_ini", SqlDbType.VarChar,100);
                comando.Parameters["@Fecha_ini"].Value = Fecha_ini;
                comando.Parameters.Add("@Fecha_fin", SqlDbType.VarChar, 100);
                comando.Parameters["@Fecha_fin"].Value = Fecha_fin;
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Compras_fecha(string Fecha_ini, string Fecha_fin)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("consulta_compra_fecha", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Fecha_ini", SqlDbType.VarChar, 100);
                comando.Parameters["@Fecha_ini"].Value = Fecha_ini;
                comando.Parameters.Add("@Fecha_fin", SqlDbType.VarChar, 100);
                comando.Parameters["@Fecha_fin"].Value = Fecha_fin;
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable facSimple(string Fecha_ini, string Fecha_fin)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("filtraCompraVentas", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Fecha_ini", SqlDbType.VarChar, 100);
                comando.Parameters["@Fecha_ini"].Value = Fecha_ini;
                comando.Parameters.Add("@Fecha_fin", SqlDbType.VarChar, 100);
                comando.Parameters["@Fecha_fin"].Value = Fecha_fin;
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable facMovi(string Fecha_ini, string Fecha_fin)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("filtraMovimientos", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Fecha_ini", SqlDbType.VarChar, 100);
                comando.Parameters["@Fecha_ini"].Value = Fecha_ini;
                comando.Parameters.Add("@Fecha_fin", SqlDbType.VarChar, 100);
                comando.Parameters["@Fecha_fin"].Value = Fecha_fin;
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable facPrestamos(string Fecha_ini, string Fecha_fin)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("filtraPrestamos", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Fecha_ini", SqlDbType.VarChar, 100);
                comando.Parameters["@Fecha_ini"].Value = Fecha_ini;
                comando.Parameters.Add("@Fecha_fin", SqlDbType.VarChar, 100);
                comando.Parameters["@Fecha_fin"].Value = Fecha_fin;
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
