using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   
    public class PersonasBD
    {

        
        public string Obtiene_num_registroperso()
        {

            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();

                SqlCommand revisa = new SqlCommand("Obti_regitro_perso", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                string valor_re = revisa.ExecuteScalar().ToString();
                return (valor_re);
            }


        }
        public void Inserta_tipo(string cedula,string rol)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();


                SqlCommand revisa = new SqlCommand("inserta_tipo_persona", conn);
                revisa.CommandType = CommandType.StoredProcedure;
                revisa.Parameters.Add("@TipoPerId", SqlDbType.VarChar).Value = cedula;
                revisa.Parameters.Add("@TipoPerNombre", SqlDbType.VarChar).Value = rol;
                revisa.ExecuteNonQuery();
            }
        }
        public void Inserta_personas(string nombre,string apellidos,string tel,string direccion,string correo,string cedula,string rol)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();

                SqlCommand inse_per = new SqlCommand("inserta_personas", conn);
                inse_per.CommandType = CommandType.StoredProcedure;
                inse_per.Parameters.Add("@PerNombre", SqlDbType.VarChar).Value = nombre;
                inse_per.Parameters.Add("@PerApellidos", SqlDbType.VarChar).Value = apellidos;
                inse_per.Parameters.Add("@PerTelefono", SqlDbType.VarChar).Value = tel;
                inse_per.Parameters.Add("@PerDireccion", SqlDbType.VarChar).Value = direccion;
                inse_per.Parameters.Add("@PerCorreo", SqlDbType.VarChar).Value = correo;
                inse_per.Parameters.Add("@PerTipoPerId", SqlDbType.VarChar).Value = cedula;
                inse_per.Parameters.Add("@PerRol", SqlDbType.VarChar).Value = rol;
                inse_per.ExecuteNonQuery();
            }
        }
        public void elimina_personas(string cedula)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();

                SqlCommand inse_per = new SqlCommand("elimina_personas", conn);
                inse_per.CommandType = CommandType.StoredProcedure;
                
                inse_per.Parameters.AddWithValue("@PerId", cedula);
                inse_per.ExecuteNonQuery();
            }
        }
        public DataTable ObtienePersonas()
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.Conexion))
            {
                conn.Open();
                SqlCommand comando = new SqlCommand("datos_personas", conn);


                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }

}
