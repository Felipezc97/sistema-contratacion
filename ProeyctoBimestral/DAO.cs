using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;


namespace ProyectoBimestral
{
    public class DAO
    {
        //permite agregar una nueva persona a la base de datos
        public static int insertarPersona(Persona nuevo)
        {
            SqlConnection conexion = MiDB.obtenerConexion();
            String consulta = "insert into tblPersona values ('" + nuevo.Cedula + "','" + nuevo.Nombre + "','" + nuevo.Titulo + "'," + nuevo.IdTipoPersonal + "," + nuevo.IdDepartamento + ",1);";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            return comando.ExecuteNonQuery();
        }

        //permite actualizar el estado de una persona
        public static int editarPersona(Persona persona)
        {
            SqlConnection conexion = MiDB.obtenerConexion();
            String consulta = "update tblPersona set idEstado= " + persona.IdEstado + "where cedula= " + persona.Cedula + "; ";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            return comando.ExecuteNonQuery();
        }

        //permite recuperar la lista de personas registradas
        public static List<Persona> obtenerListaPersona()
        {
            List<Persona> lista = new List<Persona>();
            SqlConnection conexion = MiDB.obtenerConexion();
            String consulta = "select * from tblPersona;";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.CommandTimeout = 1;
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Persona auxiliar = new Persona();
                    auxiliar.IdDepartamento = lector.GetInt32(0);
                    auxiliar.Cedula = lector.GetString(1);
                    auxiliar.Nombre = lector.GetString(2);
                    auxiliar.Titulo = lector.GetString(3);
                    auxiliar.IdTipoPersonal = lector.GetInt32(4);
                    auxiliar.IdDepartamento = lector.GetInt32(5);
                    auxiliar.IdEstado = lector.GetInt32(6);
                    lista.Add(auxiliar);
                }
            }
            return lista;
        }

        //permite devolver la lista de Estado
        public static List<Estado> obtenerListaEstado()
        {
            List<Estado> lista = new List<Estado>();
            SqlConnection conexion = MiDB.obtenerConexion();
            String consulta = "select * from tblEstado;";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Estado auxiliar = new Estado();
                    auxiliar.IdEstado = lector.GetInt32(0);
                    auxiliar.EstadoP = lector.GetString(1);
                    lista.Add(auxiliar);
                }
            }
            return lista;
        }

        //permite devolver la lista de TipoPersonal
        public static List<TipoPersonal> obtenerListaTipoPersonal()
        {
            List<TipoPersonal> lista = new List<TipoPersonal>();
            SqlConnection conexion = MiDB.obtenerConexion();
            String consulta = "select * from tblTipoPersonal;";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.CommandTimeout = 1;
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    TipoPersonal auxiliar = new TipoPersonal();
                    auxiliar.IdTipoPersonal = lector.GetInt32(0);
                    auxiliar.TipoPersonalP = lector.GetString(1);
                    lista.Add(auxiliar);
                }
            }
            return lista;
        }
        //permite devolver la lista de Departamento
        public static List<Departamento> obtenerListaDepartamento()
        {
            List<Departamento> lista = new List<Departamento>();
            SqlConnection conexion = MiDB.obtenerConexion();
            String consulta = "select * from tblDepartamento;";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.CommandTimeout = 1;
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Departamento auxiliar = new Departamento();
                    auxiliar.IdDepartamento = lector.GetInt32(0);
                    auxiliar.DepartamentoP = lector.GetString(1);
                    lista.Add(auxiliar);
                }
            }
            return lista;
        }

    }
}
