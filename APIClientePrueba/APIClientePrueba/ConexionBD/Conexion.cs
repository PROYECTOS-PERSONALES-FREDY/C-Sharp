using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace APIClientePrueba.ConexionBD
{
    internal class Conexion
    {
        string servidor = "localhost";
        string baseDatos = "PruebaTrabajo1";
        string usuario = "postgres";
        string passWord = "250436";
        string puerto = "5432";

        public DataTable leerDatos()
        {
            string cadenaConexion = $"Server = {servidor}; Port = {puerto}; User Id = {usuario}; Password = {passWord}; Database = {baseDatos}";
            NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion);
            conexion.Open();

            try
            {
                
                var sql = "select * from public.\"Cliente\"";

                NpgsqlCommand lectura = new NpgsqlCommand(sql, conexion);


                using (var reader = lectura.ExecuteReader()) 
                {
                    DataTable tabla = new DataTable();
                    tabla.Load(reader);
                    conexion.Close();
                    return tabla;
                }
                
            }
            catch (Exception ex)
            {
                conexion.Close();
                return null;
            }
        }

    }
}
