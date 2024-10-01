using Microsoft.AspNetCore.Mvc;
using prueba_fredy_camacho.ConexionBD;
using prueba_fredy_camacho.Datos;
using prueba_fredy_camacho.ProcesadoD;

namespace prueba_fredy_camacho.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class API : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<API> _logger;

        public API(ILogger<API> logger)
        {
            _logger = logger;
        }

        [HttpGet("PruebaServicio")]
        public dynamic PruebaServicio()
        {
            return "Servicio Funcionando";
        }

        [HttpPost("PruebaEnviar")]
        public dynamic PruebaEnviar(DatosPacientes persona)
        {
            try
            {
                Procesado procesado = new Procesado();

                bool estadoEnvio = procesado.procesarEnvio(persona);

                return estadoEnvio;
            }
            catch (Exception ex) { return false; }
        }

        [HttpPost("PruebaActualizar")]
        public dynamic PruebaActualizar(Actualizar actualizar)
        {
            try
            {
                Procesado procesado = new Procesado();

                bool estadoEnvio = procesado.procesarDatos(actualizar);

                return estadoEnvio;
            }
            catch (Exception ex) { return false; }
        }

        [HttpPost("PruebaEliminar")]
        public dynamic PruebaEliminar(Eliminar eliminar)
        {
            try
            {
                Procesado procesado = new Procesado();

                bool estadoEnvio = procesado.procesarEliminacion(eliminar);

                return estadoEnvio;
            }
            catch (Exception ex) { return false; }
        }


    }
}
