using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Model
{
    public class Autor
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }

        public Autor(string nombre, int edad, string nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;
        }
    }
}
