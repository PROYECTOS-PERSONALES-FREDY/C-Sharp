//https://jsonplaceholder.typicode.com/guide/ --> Java Script

using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq; // se necesita este plugin para realizar metodos json
using System.Text;


namespace Peticiones
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient()) //ejecutar peticiones a APIS
            {
                //GET -- Obtener datos

                string url = "https://jsonplaceholder.typicode.com/posts/1";

                client.DefaultRequestHeaders.Clear(); //Se elimina el encabezado de la peticion
                //client.DefaultRequestHeaders.Add("Accept", "application/json"); //Se utiliza para tokens de autorizacion

                var response = client.GetAsync(url).Result; // respuesta

                var res = response.Content.ReadAsStringAsync().Result; //obtiene la informacion de la variables response y la guarda en res

                dynamic r = JObject.Parse(res); //transforma la informacion del json y la almacena en r
                
                Console.WriteLine(r);

                //POST -- Publicar datos

                string url2 = "https://jsonplaceholder.typicode.com/posts";

                client.DefaultRequestHeaders.Clear(); //Se elimina el encabezado de la peticion
                string parametros = "{'tittle': 'Prueba1', 'body': 'Archivo JSON', 'userId': '25'}";
                dynamic jsonstring = JObject.Parse(parametros); //Transforma String en JSON

                var httpContent = new StringContent(jsonstring.ToString(), Encoding.UTF8, "application/json"); //Transforma el JSON en String 

                var response2 = client.PostAsync(url2, httpContent).Result; //se coloca el link y el contenido a enviar

                //Codigo Get para confirmar que el envio sea correcto

                var res2 = response2.Content.ReadAsStringAsync().Result; //obtiene la informacion de la variables response y la guarda en res

                dynamic r2 = JObject.Parse(res2); //transforma la informacion del json y la almacena en r

                Console.WriteLine(r2);

                //PUT -- Actualizar toda informacion

                string url3 = "https://jsonplaceholder.typicode.com/posts/1";

                client.DefaultRequestHeaders.Clear(); //Se elimina el encabezado de la peticion
                string parametros3 = "{'tittle': 'Prueba3', 'body': 'Archivo JSON', 'userId': '25'}";
                dynamic jsonstring3 = JObject.Parse(parametros3); //Transforma String en JSON

                var httpContent3 = new StringContent(jsonstring3.ToString(), Encoding.UTF8, "application/json"); //Transforma el JSON en String 

                var response3 = client.PutAsync(url3, httpContent3).Result; //se coloca el link y el contenido a enviar -- Cambia PostAsync por PutAsync

                //Codigo Get para confirmar que el envio sea correcto

                var res3 = response3.Content.ReadAsStringAsync().Result; //obtiene la informacion de la variables response y la guarda en res

                dynamic r3 = JObject.Parse(res3); //transforma la informacion del json y la almacena en r

                Console.WriteLine(r3);

                //PATCH -- Actualizar informacion precisa, uno o varios datos pero no todos

                string url4 = "https://jsonplaceholder.typicode.com/posts/1";

                client.DefaultRequestHeaders.Clear(); //Se elimina el encabezado de la peticion
                string parametros4 = "{'tittle': 'Prueba4'}";
                dynamic jsonstring4 = JObject.Parse(parametros4); //Transforma String en JSON

                var httpContent4 = new StringContent(jsonstring4.ToString(), Encoding.UTF8, "application/json"); //Transforma el JSON en String 

                var response4 = client.PatchAsync(url4, httpContent4).Result; //se coloca el link y el contenido a enviar -- Cambia PostAsync por PutAsync

                //Codigo Get para confirmar que el envio sea correcto

                var res4 = response4.Content.ReadAsStringAsync().Result; //obtiene la informacion de la variables response y la guarda en res

                dynamic r4 = JObject.Parse(res4); //transforma la informacion del json y la almacena en r

                Console.WriteLine(r4);
            }
        }
    }
}
