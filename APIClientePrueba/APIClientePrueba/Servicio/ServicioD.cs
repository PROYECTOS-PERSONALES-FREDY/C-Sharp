using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace APIClientePrueba.Servicio
{
    internal class ServicioD
    {
        public void procesarD(ObjPersona persona)
        {
            string body = JsonConvert.SerializeObject(persona);

            var options = new RestClientOptions("https://localhost:7176")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);

            var request = new RestRequest("/ControladorAPI/EnvioPersonaCarro", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            request.AddStringBody(body, RestSharp.DataFormat.Json);

            RestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);

        }

    }
}
