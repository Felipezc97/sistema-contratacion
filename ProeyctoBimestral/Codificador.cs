using ProyectoBimestral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBimestral
{
    public class Codificador
    {
        public Codificador()
        {

        }

        public static string CodificarPersona(Persona persona)
        {
            string cadena;
            cadena = persona.Cedula + ",";
            cadena = cadena + persona.Nombre + ",";
            cadena = cadena + persona.Titulo + ",";
            cadena = cadena + persona.IdTipoPersonal + ",";
            cadena = cadena + persona.IdDepartamento + ",";
            cadena = cadena + persona.IdEstado;
            return cadena;
        }

        public static Persona DecodificarPersona(string cadena)
        {
            char[] separador = new char[] { ',' };
            string[] parametros = cadena.Split(separador, 6);
            Persona persona = new Persona();
            persona.Cedula = parametros[0];
            persona.Nombre = parametros[1];
            persona.Titulo = parametros[2];
            persona.IdTipoPersonal = Convert.ToInt32(parametros[3]);
            persona.IdDepartamento = Convert.ToInt32(parametros[4]);
            persona.IdEstado = Convert.ToInt32(parametros[5]);
            return persona;
        }
    }
}
