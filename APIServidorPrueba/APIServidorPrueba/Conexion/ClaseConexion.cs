using Npgsql;

namespace APIServidorPrueba.Conexion
{
    public class ClaseConexion
    {
        string servidor = "localhost";
        string baseDatos = "PruebaTrabajo1";
        string usuario = "postgres";
        string passWord= "250436";
        string puerto = "5432";

        public bool InsertarDatos(Rootobject persona)
        {
            try { 
                string cadenaConexion = $"Server = {servidor}; Port = {puerto}; User Id = {usuario}; Password = {passWord}; Database = {baseDatos}";
                NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion);
                conexion.Open();
                string SqlInsercion =   $"insert into public.\"Cliente\" (\"Cedula\",\"Nombre\",\"Apellido\",\"Edad\")" +
                                        $"values ('{persona.persona.cedula}','{persona.persona.nombre}','{persona.persona.apellido}',{persona.persona.edad})";

                NpgsqlCommand command = new NpgsqlCommand(SqlInsercion, conexion);
                command.ExecuteNonQuery();
                conexion.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
