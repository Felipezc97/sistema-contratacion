using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoBimestral
{
    public class Departamento
    {
        //atributos de la clase
        private int idDepartamento;
        private string departamentoP;

        //metodos set y get para los atributos
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public string DepartamentoP { get => departamentoP; set => departamentoP = value; }

        public Departamento()
        {
            idDepartamento = 0;
            departamentoP = "";
        }

        //metodo toString 
        public override string ToString()
        {
            return this.departamentoP;
        }
    }
}
