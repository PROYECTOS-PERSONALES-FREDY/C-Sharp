using Conexion_Base_de_datos_con_C_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using Npgsql;// Se instala Npgsql en paquetes NuGet

namespace Interfaz
{
    class Program
    {

        static void Main(string[] args)
        {
            ConexionBD connectbd = new ConexionBD();
            string query = "insert into public.usuarios (nombre) values ('Fredy')"; //Comando de base de datos, dato a ingresar

            NpgsqlCommand cmd = new NpgsqlCommand(query, connectbd.Abrir_Conexion()); //Abrir conexion

            //Insersion de datos
            cmd.ExecuteNonQuery();
            Console.WriteLine("Dato enviado");

            //Cerrar conexion despues de actualizar base de datos
            connectbd.Cerrar_Conexion();
        }

    }
}