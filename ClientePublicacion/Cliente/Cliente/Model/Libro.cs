using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Model
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int CantidadPaginas { get; set; }
        public DateTime FechaCreacion { get; set; }
        public double Precio { get; set; }
        public bool TapaDura { get; set; }

        public Libro(string titulo, String autor, int cantidadPaginas, DateTime fechaCreacion, double precio, bool tapaDura)
        {
            Titulo = titulo;
            Autor = autor;
            CantidadPaginas = cantidadPaginas;
            FechaCreacion = fechaCreacion;
            Precio = precio;
            TapaDura = tapaDura;
        }
    }
}
