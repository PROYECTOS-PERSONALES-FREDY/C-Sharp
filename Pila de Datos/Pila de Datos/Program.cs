using System;
using System.Collections;

namespace ColaDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack(); //realizar pilas, se toman los datos del ultimo al primero
            Stack pilaClon = (Stack)pila.Clone(); //Se duplican valores en la pila

            pila.Push("Luis"); //Primer dato en pila
            pila.Push("Pedro");//Segundo dato en pila
            pila.Push("Laura");//Tercer dato en pila

            Console.WriteLine(pila.Count); //Contar numero de valores almacenados en la variable

            int tamPila = pila.Count;
            
            for (int i = 0; i < tamPila; i++)
            {
                Console.WriteLine("Dato en pila: " + pila.Pop()); //elimina el dato utilizado de la pila

                Console.WriteLine(pila.Count); //Contar numero de valores almacenados en la variable
            }

            pilaClon.Clear(); //Elimina todos los valores de la variable
            Console.WriteLine(pilaClon.Count); //Contar numero de valores almacenados en la variable


        }
    }
}