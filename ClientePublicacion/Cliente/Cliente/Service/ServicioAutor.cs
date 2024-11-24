using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cliente.Model;
using Newtonsoft.Json;
using RestSharp;

namespace Cliente.Service
{
    public class ServicioAutor
    {
        private const string BaseUrl = "http://localhost:8090";
        private const string Dominio = "/autores";

        public ServicioAutor()
        {

        }

        public List<Autor> ObtenerAutores()
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest(Dominio, Method.Get);

            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<List<Autor>>(response.Content);
        }

        public List<string> ObtenerNombresAutores()
        {
            var autores = ObtenerAutores();

            return autores?.Select(autor => autor.Nombre).ToList() ?? new List<string>();
        }

        public List<Autor> ObtenerAutoresNacionalidad(string nacionalidad)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest(Dominio + $"/nacionalidad/{nacionalidad}", Method.Get);

            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<List<Autor>>(response.Content);
        }

        public List<Autor> ObtenerAutoresEdad(int edad)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest(Dominio + $"/edad/{edad}", Method.Get);

            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<List<Autor>>(response.Content);
        }

        public bool AgregarAutor(string nombrex, int edadx, string nacionalidadx, double porcentajeRegaliasx, DateTime fechaNacimientox)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest(Dominio + "/agregar", Method.Post);


            request.AddHeader("Content-Type", "application/json");

            request.AddBody(new
            {
                nombre = nombrex,
                edad = edadx,
                nacionalidad = nacionalidadx,
                regalias = porcentajeRegaliasx,
                fechaNacimiento = fechaNacimientox.ToString("yyyy-MM-ddTHH:mm:ss")
        });

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                return true;
            }
            return false;
        }

        public Autor BuscarAutor(string nombre)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest(Dominio + $"/buscar/{nombre}", Method.Get);

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Autor>(response.Content);
            }
            return null;
        }

        public bool ActualizarAutor(string nombreAntiguo, string nombrex, int edadx, string nacionalidadx, double porcentajeRegaliasx, DateTime fechaNacimientox)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest($"/autores/actualizar/{nombreAntiguo}", Method.Put);

            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(new
            {
                nombre = nombrex,
                edad = edadx,
                nacionalidad = nacionalidadx,
                regalias = porcentajeRegaliasx,
                fechaNacimiento = fechaNacimientox.ToString("yyyy-MM-ddTHH:mm:ss")
            });

            var response = client.Execute(request);

            return response.IsSuccessful;
        }

        public bool EliminarAutor(string nombre)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest(Dominio + $"/borrar/{nombre}", Method.Delete);

            var response = client.Execute(request);

            return response.IsSuccessful;
        }
    }
}
