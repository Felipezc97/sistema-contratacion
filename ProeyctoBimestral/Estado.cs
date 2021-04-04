using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoBimestral
{
    public class Estado
    {
        //atributos de la clase
        private int idEstado;
        private string estadoP;

        //metodos set y get para los atributos
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string EstadoP { get => estadoP; set => estadoP = value; }

        public Estado()
        {
            IdEstado = 0;
            estadoP = " ";
        }
        public override string ToString()
        {
            return estadoP;
        }
    }
}
