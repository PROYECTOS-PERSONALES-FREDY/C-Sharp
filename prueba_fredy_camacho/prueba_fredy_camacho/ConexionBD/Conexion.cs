using Npgsql;
using prueba_fredy_camacho.Datos;

namespace prueba_fredy_camacho.ConexionBD
{
    public class Conexion
    {
        string servidor = "localhost";
        string puerto = "5432";
        string usuario = "postgres";
        string passWord = "250436";
        string NombreBD = "prueba_fredy_camacho";

        public bool enviarDatos(DatosPacientes persona)
        {
            try
            {
                string DatosConexion = $"Server = {servidor}; Port = {puerto}; User Id = {usuario}; Password = {passWord} ; Database = {NombreBD}";

                NpgsqlConnection con = new NpgsqlConnection(DatosConexion);

                con.Open();

                string insertarSQL = $"insert into public.\"pacientes\" (\"TipoD\", \"NDocumento\", \"Nombres\", \"Apellidos\", \"Correo\", \"Telefono\", \"FechaN\", \"Afiliacion\" )" +
                                     $"values('{persona.persona.tipoDocumento}',{persona.persona.numeroD},'{persona.persona.nombres}','{persona.persona.apellidos}','{persona.persona.correo}',{persona.persona.telefono},'{persona.persona.fechaNacimiento}','{persona.persona.afiliacion}') ";
                
                NpgsqlCommand com = new NpgsqlCommand(insertarSQL,con);
                com.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception ex) 
            {
                return false;
            } 
        }

        public bool actualizarDatos(Actualizar actualizar)
        {
            try
            {
                string DatosConexion = $"Server = {servidor}; Port = {puerto}; User Id = {usuario}; Password = {passWord} ; Database = {NombreBD}";

                NpgsqlConnection con = new NpgsqlConnection(DatosConexion);
                con.Open();

                string actualizarSQL = $"update public.\"pacientes\" set \"{actualizar.ActualizarD.titulo}\" = '{actualizar.ActualizarD.texto}'" +
                                     $"where \"{actualizar.ActualizarD.titulo}\" = '{actualizar.ActualizarD.dato}' and \"NDocumento\" = '{actualizar.ActualizarD.numeroD}'";

                    NpgsqlCommand com = new NpgsqlCommand(actualizarSQL, con);
                    com.ExecuteNonQuery();
                    con.Close();

                    return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool eliminarDatos(Eliminar eliminar)
        {
            try
            {
                string DatosConexion = $"Server = {servidor}; Port = {puerto}; User Id = {usuario}; Password = {passWord} ; Database = {NombreBD}";

                NpgsqlConnection con = new NpgsqlConnection(DatosConexion);
                con.Open();

                string eliminarSQL = $"delete from public.\"pacientes\"" +
                                     $"where \"{eliminar.EliminarD.titulo}\" = '{eliminar.EliminarD.dato}'";

                NpgsqlCommand com = new NpgsqlCommand(eliminarSQL, con);
                com.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
