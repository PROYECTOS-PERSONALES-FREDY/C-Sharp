﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;


namespace Interfaz
{
    class Program
    {

        static void Main(string[] args)
        {
            Ave pajaro1 = new Ave();
            pajaro1.Nombre = "Loro";
            pajaro1.volar();
            Console.WriteLine(pajaro1.Nombre);

        }

    }
}