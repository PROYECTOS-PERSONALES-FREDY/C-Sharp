using APIClientePrueba.ConexionBD;
using APIClientePrueba.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace APIClientePrueba.Logica
{
    internal class LogicaD
    {
        public bool leerTabla() 
        {
            DataTable tabla = new DataTable();
            Conexion con = new Conexion();
            ServicioD ser = new ServicioD();
            
            tabla = con.leerDatos();

            foreach (DataRow row in tabla.Rows) 
            {
                ObjPersona per = new ObjPersona();
                Persona per2 = new Persona();

                per.persona = per2;

                string nombre = row["Nombre"].ToString();
                per2.nombre = nombre;

                per2.apellido = row["Apellido"].ToString();
                per2.edad = int.Parse(row["Edad"].ToString());
                per2.cedula = row["Cedula"].ToString();

                ser.procesarD(per);

            }

            return true;
        }
    }
}
