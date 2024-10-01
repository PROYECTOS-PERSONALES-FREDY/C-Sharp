using prueba_fredy_camacho.ConexionBD;
using prueba_fredy_camacho.Datos;

namespace prueba_fredy_camacho.ProcesadoD
{
    public class Procesado
    {

        public bool procesarEnvio(DatosPacientes persona)  
        {
            Conexion conexion = new Conexion();

            try 
            {
                bool estado = conexion.enviarDatos(persona);
                return estado;
            }
            catch (Exception ex) { return false; } 
            
            
        }
        public bool procesarDatos(Actualizar actualizar)
        {
            Conexion conexion = new Conexion();

            try
            {
                bool estado = conexion.actualizarDatos(actualizar);
                return estado;
            }
            catch (Exception ex) { return false; }


        }

        public bool procesarEliminacion(Eliminar eliminar)
        {
            Conexion conexion = new Conexion();

            try
            {
                bool estado = conexion.eliminarDatos(eliminar);
                return estado;
            }
            catch (Exception ex) { return false; }


        }
    }
}
