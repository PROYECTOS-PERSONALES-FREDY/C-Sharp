

//*************************
//********Variables********
//*************************

int numero = 10;
int fecha = Convert.ToInt16("12"); //Clase Convert. --> String a entero // solo numeros en el String

string amarillo = "amarillo";
string name = "";
float digitos7 = 2.5F;
double digitos16 = 7.4;
decimal digitos28 = 9.8M;

bool valor = false;

char letra = 'A'; //siempre en comillas simples

//************************
//********Vectores********
//************************

string[] cadenas = new string[5];
int[] edad = new int[5];
string[] pruebavector = { "A", "B", "C", "D", "E", "F", "G" };
cadenas[0] = "Fredy";
edad[0] = 16;
Console.WriteLine("Hello World! " + cadenas[0]); //se utiliza para imprimir un mensaje // Se imprime variables
Console.WriteLine("Hello World! " + edad[0]); //se utiliza para imprimir un mensaje // Se imprime variables

//************************
//********Matrices********
//************************

int[,] matriz = new int[2, 2];// filas x columnas
matriz[0, 0] = 5;
matriz[0, 1] = 0;
matriz[1, 0] = 9;
matriz[1, 1] = 2;

Console.WriteLine("Matriz {0}", matriz[0, 0]); //se utiliza para imprimir un mensaje // Se imprime variables

//************************
//********Operador********
//************************

numero += fecha; // Suma variables y guarda en variable "numero"
numero -= fecha; // Resta variables y guarda en variable "numero"
numero *= fecha;
numero /= fecha;
numero %= fecha;

var data = numero < fecha; // var se utiliza si la condicion es verdadera o falsa


//-----------Suma de String (inmutabilidad)-----------



//****************************************
//********Operadores condicionales********
//****************************************

if (data == true && data != false || numero > 1)
{
    Console.WriteLine("Verdadero", data);
}
else
{
    Console.WriteLine("falso", data);
}

//****************************************
//********Operadores condicionales********
//****************************************

if (data == true && data != false || numero > 1)
{
    Console.WriteLine("Verdadero", data);
}
else
{
    Console.WriteLine("falso", data);
}

name = data ? "Alex" : "Jose";// variable = operador bool ? si es verdadero pone esta variable : si es falso pone esta variable
name = numero < fecha ? "Alex" : "Jose";// variable = operador bool ? si es verdadero pone esta variable : si es falso pone esta variable


//**********************
//********Bucles********
//**********************

//--------For--------

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("numero bucle: {0}", i);
}



for (int i = 0; i < pruebavector.Length; i++) // .Length se utiliza para contar el numero de espacios dentro del vector
{
    Console.WriteLine("Letra en vector: {0}", pruebavector[i]);
}


//--------foreach--------


foreach (var item in pruebavector)
{
    Console.WriteLine("Letra en vector: {0}", item);
}

//--------Switch--------

var switch_on = 5;

switch (switch_on)
{
    case 5:
        Console.WriteLine("Caso: {0}", switch_on);
        break;

    /*case "Hola": //No se pueden colocar variables de String si se evalua un entero
        Console.WriteLine("Caso: {0}", switch_on);
        break;
    */
    default: //se ejecuta cuando no se encuentra el valor en el switch, es como el ELSE
        Console.WriteLine("Error", switch_on);
        break;
}

var switch_on2 = 3;
var result2 = switch_on2 switch
{
    1 => "Jose",
    2 => "Alejo",
    3 => "B"
};
Console.WriteLine("Resultado {0}", result2);

var (a, b, opcion) = (6, 8, "+"); //Se crea una lista y se le asigna varlor a cada variable
var result3 = opcion switch
{
    "+" => a + b,
    "-" => a - b,
    "*" => a * b
};
Console.WriteLine("Resultado {0}", result3);

//**********************
//********Bucles********
//**********************


var count = 1;
var bucle1 = true;
while (bucle1)
{
    if (count == 10) { bucle1 = false; }
    Console.WriteLine("Resultado {0}", count);
    count++;
}


/*
do
{

} while (true);
*/

//*****************************
//********Visualizacion********
//*****************************

Console.WriteLine("Hello World! " + numero); //se utiliza para imprimir un mensaje // Se imprime variables
Console.WriteLine("Hello World! {0} {1}", numero, letra, amarillo, fecha); //se utiliza para imprimir un mensaje // Segunda forma de imprimir variables de forma vectorizada, numero marca la posicion
Console.WriteLine("Hello World! {2} {0} {3}", numero, letra, amarillo, fecha); //se utiliza para imprimir un mensaje // Segunda forma de imprimir variables de forma vectorizada, numero marca la posicion

Console.WriteLine("Resultado {0}", data);

Console.ReadLine(); //se utiliza para capturar datos