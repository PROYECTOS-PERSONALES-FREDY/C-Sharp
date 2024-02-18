using APIServidorPrueba.Conexion;

namespace APIServidorPrueba.Logica
{
    public class Metodo
    {
        public string[] Procesarobjeto(Rootobject persona)
        {   
            ClaseConexion conexion = new ClaseConexion(); // crea un objeto para la conexion a la base de datos
            string[] Validaciones = new string[2];

            try { 
                if (persona == null)
                    {
                    Validaciones[0] = "false";
                    Validaciones[1] = "Objeto Vacio";
                    return Validaciones;
                    }
                else
                    {
                    bool InsersionPersona = conexion.InsertarDatos(persona);

                    if (InsersionPersona)
                    {
                        Validaciones[0] = "true";
                        Validaciones[1] = "Enviado Correctamente";
                        return Validaciones;
                    }
                    else
                    {
                        Validaciones[0] = "false";
                        Validaciones[1] = "No se puedo guardar informacion";
                        return Validaciones;
                    }
                    
                }
    
            }
   
                
            catch (Exception ex) {
                Validaciones[0] = "false";
                Validaciones[1] = $"Error [{ex.ToString()}]";
                return Validaciones;
            }



        }
    }
}
