using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json; // se necesita este plugin para realizar metodos json


namespace API_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]//Controlador API

    public class Primer_Controlador : ControllerBase // Se coloca ControlerBase
    {
        // GET
        [HttpGet] //Cuando en la pagina web se da GET devuelve la frase hola mundo

        public string Get()
        {
            return "Hola Mundo";
        }

        [HttpGet("GetSaludo/{nombre}")] // son enpoints
        public string Get(string nombre)// En el get se onbiente el dato escrito en la pagina web
        {
            return "Hola " + nombre; // se devuelve una respuesta a la pagina web
        }



        private struct User
        {
            public int id;
            public string nombre;
            public string edad;
        }



        [HttpGet("GetUsuario/{id}/{nombre}/{edad}")]
        public string Get(int id, string nombre, string edad)// En el get se pone la variable donde se almacenara el dato escrito en la pagina web
        {
            User usuario = new User(); //se llama la clase user para utilizar sus variables
            usuario.id = id;
            usuario.nombre = nombre;
            usuario.edad = edad;

            string respuesta = JsonConvert.SerializeObject(usuario); //Se reenvia en un archivo JSON
            return respuesta;
        }



        //Post

        public class UsuarioP
        { 
            public int id { get; set; }
            public string name { get; set; }
        }

        [HttpPost("PostUser")] //Se usa para recopilar datos de usarios dentro de una base de datos "Usuario" 
        public string Post(UsuarioP usuario)
        {
            return JsonConvert.SerializeObject(usuario);
        }

        //Patch

        [HttpPatch("UpdateUser")] //Se usa para actualizar informacion dentro de la base de datos
        public string Patch(UsuarioP usuario)
        {
            return "Se actualizo el usuario correctamente";
        }

        //Delete

        [HttpDelete("PostUser")] //Se usa para eliminar informacion dentro de la base de datos
        public string Delete(int idusuario)
        {
            return "Se elimino el usuario correctamente";
        }
    }
}
