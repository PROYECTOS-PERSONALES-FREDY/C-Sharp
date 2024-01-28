using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Carro
    {
        public int numero_ruedas; //Variable publica se puede acceder desde cualquier archivo
        private int numero_puertas; //Solo la clase coche puede acceder a esta variable
        protected int luz;   //solo los derivados de clase coche puede acceder
        private string color;
        private double velocidad;

        public Carro(int numero_ruedas, int numero_puertas) //Constructor, asignar variables 
        {
            this.numero_ruedas = numero_ruedas;
            this.numero_puertas = numero_puertas;
        }    


        public int getnumeroRuedas() //Funciones
        {
            return numero_ruedas;
        }

        public void setNumeroRuedas(int numero_ruedas)
        {
            this.numero_ruedas = numero_ruedas;  //this se utiliza para llamar la variable publica fuera del metodo con el mismo nombre, llamar variables de la clase, si no se usa se usa la variable de la funcion
        }

    }
}
