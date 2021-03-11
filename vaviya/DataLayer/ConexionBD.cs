using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DataLayer
{
    public static class ConexionBD
    {
     
            


        public static string Conexion
        {
            get { return ConfigurationManager.ConnectionStrings["VAVIYACS"].ConnectionString;

            }
        }


    }
}
