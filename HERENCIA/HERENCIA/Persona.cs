using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    internal class Persona
    {
        private string nombre;
        private string edad;
        private string sexo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public Persona()
        { 

        }

        public string Saludar()
        {
            return "Hola";
        }

    }
}
