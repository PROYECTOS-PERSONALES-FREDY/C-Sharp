

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo1 = new Circulo(); // se crea un objeto de tipo circulo y se inicia para usar la clase para tener sus propiedades y metodos, ejemplo: pi y calculoArea / la parte new llama al constructor

            Console.WriteLine(circulo1.calculoArea(5));

            Conversor conversor = new Conversor();

            Console.WriteLine(conversor.USD_COP(10));

            coche coche1 = new coche(); // objeto coche / new llama al constructor para dar un estado inicial

            Console.WriteLine(coche1.getLargo());

            coche coche2 = new coche(5000,8000);//Sobrecarga de construntor, definir caracteristicas inicales

            Console.WriteLine(coche2.getLargo());

        }
    }

    class Circulo
    {
        //hay un constructor por defecto, esta vacio

        private const double pi = 3.1416; //Se coloca private para evitar editar la constante, encapsulacion de la variable

        public double calculoArea(int radio) //Metodo 
        {
            return pi * radio * radio;
        }
    }

    class Conversor
    {
        private double valCOP = 3901;

        public void cambiarCOP(double nuevoValor) //se realiza un metodo de acceso para el cambio de la moneda pero con condiciones para evitar cambios erroneos
        {
            if (nuevoValor > 0) valCOP = nuevoValor; //condicion para cambiar el valor
            else Console.WriteLine("DatoErroneo");
        }

        public double USD_COP(double moneda)
        {
            return moneda*valCOP;
        }

    }

    class coche
    {
        private int ruedas; //Caracteristicas de coche
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

        

        //Constructores

        public coche() //Metodo constructor, sirve para darle unas caracteristicas inciales a los objetos// Tiene obligatoriamente el mismo nombre de la clase, sin return
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 800.2;
        }

        public coche(double largoC, double anchoC) // Sobrecarga de cosntructor, cuando se quieren definir otras caracteristicas por defecto
        {
            ruedas = 4;
            largo = largoC; 
            ancho = anchoC;
        }


        // Metodos Getter

        public int getRuedas() //metodo para solo leer el valor de ruedas sin posibilidad de poderse cambiar
        {
            return ruedas;
        }

        public double getLargo() //metodo para solo leer el valor de ruedas sin posibilidad de poderse cambiar
        {
            return largo;
        }
        public double getAncho()
        {
            return ancho;
        }

        //Metodos Setter

        public void setClimatizador(bool climatizador) //asigna valor a una variable
        {
            this.climatizador = climatizador; //se usa this para hacer referencia a la variable dentro de la clase
        }


        //Forma resumida para hacer get y set
        public string Tapiceria { get => tapiceria; set => tapiceria = value; }



    }
}
