using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    internal class Registro
    {
        public string nombre;
        public string apellido;
        public int edad;
        public string pais;


        public Registro(string nombre, string apellido, int edad, string pais)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.pais = pais;
        }

        public Registro()
        {

        }

    }
}
