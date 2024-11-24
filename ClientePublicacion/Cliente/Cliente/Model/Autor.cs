using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cliente.Model
{
    public class Autor
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }

        [JsonProperty("regalias")]
        public double PorcentajeRegalias { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Autor(string nombre, int edad, string nacionalidad, double porcentajeRegalias, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;
            PorcentajeRegalias = porcentajeRegalias;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
