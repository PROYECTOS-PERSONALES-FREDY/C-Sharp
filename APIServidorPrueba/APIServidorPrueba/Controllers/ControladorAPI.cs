using APIServidorPrueba.Logica;
using Microsoft.AspNetCore.Mvc;

namespace APIServidorPrueba.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ControladorAPI : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ControladorAPI> _logger;

        public ControladorAPI(ILogger<ControladorAPI> logger)
        {
            _logger = logger;
        }

        [HttpGet("Validar Servicio")]
        public dynamic ValidarServicio()
        {
            string servicio = string.Empty;
            servicio = "Servicio Funcionando";
            return new
            { 
                servicio = servicio,
                estadoServicio = 200
            };
        }

        [HttpPost("EnvioPersonaCarro")]

        public dynamic EnvioPersona([FromBody] Rootobject persona)
        {
            Metodo metodos = new Metodo();
            string[] DatosEstado = new string[2];
            DatosEstado = metodos.Procesarobjeto(persona);

            bool estado = Convert.ToBoolean(DatosEstado[0]);
            string confirmacion = DatosEstado[1];

            return new
            {
                Estatus = estado,
                Confirmacion = confirmacion

            };
        }

    }
}
