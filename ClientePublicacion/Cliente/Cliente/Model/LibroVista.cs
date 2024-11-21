using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Model
{
    public class LibroVista
    {
        public string Titulo { get; set; }
        public string Autores { get; set; }
        public int CantidadPaginas { get; set; }
        public DateTime FechaCreacion { get; set; }
        public double Precio { get; set; }
        public bool TapaDura { get; set; }
    }
}
