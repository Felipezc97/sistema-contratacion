using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace ProyectoBimestral
{
    public class MiDB
    {
        //el siguiente metodo realiza la conexion con la base de datos 
        public static SqlConnection obtenerConexion()
        {
            //se debe colocar la conexion con la base de datos
            SqlConnection conexion = new SqlConnection(@"Data Source=PC-FELIPE;Initial Catalog=dbProyecto1;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}
