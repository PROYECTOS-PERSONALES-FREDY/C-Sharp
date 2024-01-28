using Clases;
using System;
using System.Collections;

namespace ColaDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carro auto1 = new Carro(4,4); //Definir objetos

            auto1.setNumeroRuedas(7);
            Console.WriteLine(auto1.getnumeroRuedas());

        }
    }
}