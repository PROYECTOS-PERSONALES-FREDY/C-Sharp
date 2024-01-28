using System;
using System.Collections;
using System.Collections.Generic;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            factorial(numero);

            Console.WriteLine("El factorial es {0}",factorial(numero));
        }

        static int factorial(int numero)
        {
            if(numero == 1)
            {
                return 1;

            }
            else { 
                return numero * factorial(numero - 1); 
            }
        }
    }
}