using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Cliente.Model;
using System.Windows.Forms;
using System.Dynamic;
using System.Net;
using System.Linq;


namespace Cliente.Service
{
    public class ServicioLibroCliente
    {
        private const string BaseUrl = "http://localhost:8080";

        public ServicioLibroCliente()
        {

        }

        public List<Libro> ObtenerLibros()
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest("/libros", Method.Get);

            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<List<Libro>>(response.Content);
        }

        public List<Libro> ObtenerLibrosAutor(String autor)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest("/libros/autor/"+autor, Method.Get);

            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<List<Libro>>(response.Content);

        }

        public bool AgregarLibro(string titulox, String autorx, int paginas, DateTime fecha, double preciox, bool tapaDurax)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest("/libros/agregar", Method.Post);

            request.AddHeader("Content-Type", "application/json");
            var fechaISO = fecha.ToString("yyyy-MM-ddTHH:mm:ss");

            if(autorx=="")
            {
                var body = new
                {
                    titulo = titulox,
                    cantidadPaginas = paginas,
                    fechaCreacion = fechaISO,
                    precio = preciox,
                    tapaDura = tapaDurax
                };
                request.AddBody(body);
            }
            else
            {
                var body = new
                {
                    titulo = titulox,
                    autor = autorx,
                    cantidadPaginas = paginas,
                    fechaCreacion = fechaISO,
                    precio = preciox,
                    tapaDura = tapaDurax
                };
                request.AddBody(body);
            }
            
          

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                return true;
            }
            return false;
        }

        public Libro BuscarLibroPorTitulo(string titulo)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest($"/libros/buscar/{titulo}", Method.Get);

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Libro>(response.Content);
            }
            return null;
        }

        public Libro BuscarLibroPorAutor(string autor)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest($"/libros/buscarAutor/{autor}", Method.Get);

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Libro>(response.Content);
            }
            return null;
        }

        public Libro BuscarLibroCompleto(string titulo, string autor)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest("/libros/buscarCompleto", Method.Get);
            request.AddQueryParameter("titulo", titulo);
            request.AddQueryParameter("autor", autor);

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Libro>(response.Content);
            }
            return null;
        }

        public bool EliminarLibro(string titulo)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest($"/libros/borrar/{titulo}", Method.Delete);

            var response = client.Execute(request);

            return response.IsSuccessful;
        }

        public bool ActualizarLibro(string tituloAntiguo, int paginasx, double preciox, string titulox, DateTime fechax, string autorx, bool tapaDurax)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest($"/libros/actualizar/{tituloAntiguo}", Method.Put);

            request.AddHeader("Content-Type", "application/json");
            var fechaISO = fechax.ToString("yyyy-MM-ddTHH:mm:ss");

            request.AddJsonBody(new
            {
                cantidadPaginas = paginasx,
                precio = preciox,
                titulo = titulox,
                fechaCreacion = fechaISO,
                autor = autorx,
                tapaDura = tapaDurax
            });

            var response = client.Execute(request);

            return response.IsSuccessful;
        }
    }
}