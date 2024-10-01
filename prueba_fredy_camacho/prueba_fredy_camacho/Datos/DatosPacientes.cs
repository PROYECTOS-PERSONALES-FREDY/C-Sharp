using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prueba_fredy_camacho.Datos
{
    public class DatosPacientes
    {
        public Persona persona {  get; set; }
    }
    public class Persona
    {
        public string tipoDocumento {  get; set; }
        public int numeroD { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public string fechaNacimiento { get; set; }
        public string afiliacion { get; set; }

    }
}
