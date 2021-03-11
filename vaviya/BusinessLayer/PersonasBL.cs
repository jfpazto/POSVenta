using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonasBL
    {
        PersonasBD datos = new PersonasBD();
        public string LLama_regis_perso()
        {
            string numero;
            try
            {
                numero = datos.Obtiene_num_registroperso();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return numero;
        }
        public void LLama_tipo_personas(string cedula, string rol)
        {
            datos.Inserta_tipo(cedula,rol);

        }
        public void LLamas_ingre_personas(string nombre, string apellidos, string tel, string direccion, string correo, string cedula,string rol)
        {
            datos.Inserta_personas(nombre, apellidos, tel, direccion, correo, cedula,rol);

        }
        public void LLama_elimina_personas(string cedula)
        {
            datos.elimina_personas(cedula);

        }
        public DataTable ObtenerPersonas()
        {
            DataTable dt = null;
            try
            {
                dt = datos.ObtienePersonas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
    }
}
