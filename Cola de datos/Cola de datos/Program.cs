using System;
using System.Collections;

namespace ColaDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue(); //realizar filas, se toman los datos en el orden que van llegando a la variable
            Queue filaClon = (Queue)fila.Clone(); //Se duplican valores en fila

            fila.Enqueue("Luis"); //Primer dato en fila
            fila.Enqueue("Pedro");//Segundo dato en fila
            fila.Enqueue("Laura");//Tercer dato en fila

            Console.WriteLine(fila.Count); //Contar numero de valores almacenados en la variable

            for (int i = 0; i < 3; i++) {

                Console.WriteLine("Dato en fila: " + fila.Dequeue()); //elimina el dato utilizado de la fila

                Console.WriteLine(fila.Count); //Contar numero de valores almacenados en la variable
            } 

            filaClon.Clear(); //Elimina todos los valores de la variable
            Console.WriteLine(filaClon.Count); //Contar numero de valores almacenados en la variable


        }
    }
}