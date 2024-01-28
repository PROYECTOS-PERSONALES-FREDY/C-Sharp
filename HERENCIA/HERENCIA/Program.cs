using System;
using System.Collections;
using System.Collections.Generic;


namespace HERENCIA
{
    class Program { 
    
    static void Main(string[] args)
        {
            Policia poli = new Policia();

            Console.WriteLine(poli.Saludar());

            poli.Edad = "30";
            poli.Nombre = "Juan";
            poli.Sexo = "Masculino";

            Console.WriteLine("{0} {1} {2}",poli.Edad,poli.Nombre,poli.Sexo);

        }

    }
}