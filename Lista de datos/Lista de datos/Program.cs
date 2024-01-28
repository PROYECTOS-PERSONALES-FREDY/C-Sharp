using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ColaDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista_de_prueba1= new List<string>();

            lista_de_prueba1.Add("Juan");
            lista_de_prueba1.Add("Angel"); //Inicializar lista 1
            lista_de_prueba1.Add("Roberto"); //Inicializar lista 1
            lista_de_prueba1.Add("Paula"); //Inicializar lista 1
            lista_de_prueba1.Add("Alberto"); //Inicializar lista 1

            List<string> lista_de_prueba2 = new List<string>() { 
              "Pedro",
              "Pablo"
            }; // Inicializar lista 2


            foreach (var nombre in lista_de_prueba1) // para cada dato en lista de pruebas...
            {
                Console.WriteLine(nombre); //se imprime
            }
            Console.WriteLine("\n");

            lista_de_prueba1.Insert(1,"Fredy");//Insertar un dato en la lista

            foreach (var nombre in lista_de_prueba1) // para cada dato en lista de pruebas...
            {
                Console.WriteLine(nombre); //se imprime
            }
            Console.WriteLine("\n");

            lista_de_prueba1.RemoveAt(2); //Eliminar dato 

            foreach (var nombre in lista_de_prueba1) // para cada dato en lista de pruebas...
            {
                Console.WriteLine(nombre); //se imprime
            }
            Console.WriteLine("\n");

            lista_de_prueba1.RemoveAll(nombre =>
            {
                if(nombre.StartsWith("J"))// Si la variable empiza con J

                    return true;
                else { 
                    return false; 
                }
                
            }); //Elimina todos los datos con las caracteristicas dichas

            foreach (var nombre in lista_de_prueba1) // para cada dato en lista de pruebas...
            {
                Console.WriteLine(nombre); //se imprime
            }
            Console.WriteLine("\n");

            lista_de_prueba1.Sort(); //Organiza la lista de A a Z

            foreach (var nombre in lista_de_prueba1) // para cada dato en lista de pruebas...
            {
                Console.WriteLine(nombre); //se imprime
            }
            Console.WriteLine("\n");

            lista_de_prueba1.Reverse(); //Organiza la lista de Z a A

            foreach (var nombre in lista_de_prueba1) // para cada dato en lista de pruebas...
            {
                Console.WriteLine(nombre); //se imprime
            }
            Console.WriteLine("\n");

        }
    }
}