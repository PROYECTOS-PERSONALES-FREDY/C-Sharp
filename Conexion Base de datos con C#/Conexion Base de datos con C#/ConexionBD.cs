using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql; //Se añade libreria

namespace Conexion_Base_de_datos_con_C_
{
    internal class ConexionBD
    {
        private NpgsqlConnection conn;


        public ConexionBD() //Conexion con base de datos
        {
            conn = new NpgsqlConnection("Server = localhost; Port =5432; User Id = postgres; Password =123; Database = Ejemplo1");
        }

        public NpgsqlConnection Abrir_Conexion()
        {
            try // Se utiliza try y catch por si hay algun error de conexion
            {
                conn.Open(); //Abrir conexion
                Console.WriteLine("Se realizo conexión...");
                return conn;
            }catch(Exception ex)
            {
                Console.WriteLine("Error de conexión");
                return null; //en dado caso que no funcione
            }
        }

        public void Cerrar_Conexion()
        { conn.Close(); }

    }
}
