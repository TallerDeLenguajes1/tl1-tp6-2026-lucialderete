/*
-------PUNTO 1--------------
using System;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);



-------PUNTO 2--------------
Console.WriteLine("Ingrese un numero positivo: ");
string numeroIngresado = Console.ReadLine();
if(int.TryParse(numeroIngresado, out int numero)){
    if(numero > 0){
        int invertido=0;
        int aux = numero;
        while(numero > 0){
            int resto = numero %10;
            invertido =(invertido * 10)+resto;
            numero /= 10;
        }
        Console.WriteLine($"Numero invertido: {invertido}");
        Console.WriteLine($"Numero ingresado: {aux}");

    }else{
        Console.WriteLine("Ingrese un numero positivo");
    }

}else{
    Console.WriteLine("error en el numero ingresado");
}



-------PUNTO 3--------------

Console.WriteLine("---CALCULADORA---");
int opcion;
do
{
    Console.WriteLine("Ingrese una opcion: ");
    Console.WriteLine("1) Suma");
    Console.WriteLine("2) Resta");
    Console.WriteLine("3) Multiplicacion");
    Console.WriteLine("4) Dividir");
    Console.WriteLine("5) Valor Absoluto");
    Console.WriteLine("6) Cuadrado");
    Console.WriteLine("7) Raiz Cuadrada");
    Console.WriteLine("8) Seno");
    Console.WriteLine("9) Coseno");
    Console.WriteLine("10) Parte entera del float");
    Console.WriteLine("0) Salir");

    string op = Console.ReadLine();

    if (int.TryParse(op, out opcion))
    {
        if (opcion == 0) break;

        double resultado = 0;
        if (opcion >= 1 && opcion <= 4)
        {
            //para las operaciones que necesito 2 numeros
            Console.WriteLine("Ingrese el primer numero: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero: ");
            string num2 = Console.ReadLine();

            if (double.TryParse(num1, out double n1) && double.TryParse(num2, out double n2))
            {
                switch (opcion)
                {
                    case 1:
                        resultado = n1 + n2;
                        break;
                    case 2:
                        resultado = n1 - n2;
                        break;
                    case 3:
                        resultado = n1 * n2;
                        break;
                    case 4:
                        if (n2 != 0)
                        {
                            resultado = n1 / n2;
                        }
                        else
                        {
                            Console.WriteLine("Error, no se puede divir en 0");
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion no valida xd");
                        break;
                }
                Console.WriteLine($"El resultado es: {resultado}");
            }
        }
        else if (opcion >= 5 && opcion <= 10)
        {
            Console.WriteLine("Ingrese un numero: ");
            string num1 = Console.ReadLine();
            if (double.TryParse(num1, out double n1))
            {
                switch (opcion)
                {
                    case 5:
                        resultado = Math.Abs(n1);
                        break;
                    case 6:
                        resultado = Math.Pow(n1, 2);
                        break;

                    case 7:
                        resultado = Math.Sqrt(n1);
                        break;
                    case 8:
                        resultado = Math.Sin(n1);
                        break;
                    case 9:
                        resultado = Math.Cos(n1);
                        break;
                    case 10:
                        resultado = Math.Truncate(n1);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida xd");
                        break;
                }
            }

            Console.WriteLine($"El resultado es: {resultado}");
        }
        else
        {
            Console.WriteLine("Opcion no valida :( )");
        }
    }


} while (opcion != 0);
Console.WriteLine("Ingrese el primer numero: ");
string nume1 = Console.ReadLine();
Console.WriteLine("Ingrese el segundo numero: ");
string nume2 = Console.ReadLine();

if (double.TryParse(nume1, out double numero1) && double.TryParse(nume2, out double numero2))
{
    if(numero1 > numero2)
    {
        Console.WriteLine($"El numero {numero1} es mayor a {numero2}");
    }
    else if(numero2 > numero1)
    {
        Console.WriteLine($"El numero {numero2} es mayor a {numero1}");

    }
    else
    {
        Console.WriteLine($"Los numeros {numero1}y {numero2} son iguales");
    }
}


Console.WriteLine("Fin del programa uwu");


-------PUNTO 4--------------
*/

using System.IO.Pipelines;

Console.WriteLine("Ingrese una cadena:");
string cadena1 = Console.ReadLine();
Console.WriteLine($"La longitud es: {cadena1.Length}");

Console.WriteLine("Ingrese una segunda cadena:");
string cadena2 = Console.ReadLine();
string concatenada = cadena1 + " " + cadena2;
Console.WriteLine($"Concatenación: {concatenada}");

string sub = cadena1.Substring(0, Math.Min(3, cadena1.Length));
Console.WriteLine($"Subcadena (primeros 3): {sub}");

double n1 = 10;
double n2 = 5;
double res = n1 + n2;
Console.WriteLine($"La suma de {n1.ToString()} y de {n2.ToString()} es igual a: {res.ToString()}");

foreach (char c in cadena1)
{
    Console.WriteLine(c);
}

Console.WriteLine("Ingrese palabra a buscar:");
string palabra = Console.ReadLine();
if (cadena1.IndexOf(palabra) != -1) Console.WriteLine("Palabra encontrada");

Console.WriteLine(cadena1.ToUpper());
Console.WriteLine(cadena1.ToLower());

/*--------PREGUNTAR --------------
Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
por pantalla “582+2” y que le devuelva la suma de 582 con 2
*/

Console.Write("Ingrese una ecuacion simple: ");
string ecuacion = Console.ReadLine();

char[] operadores = { '+', '-', '*', '/' };
char operador = ' ';

foreach (char operacion in operadores)
{
    if (ecuacion.Contains(operacion))
    {
        operador = operacion;
        break;
    }
}

if (operador == ' ')
{
    Console.WriteLine("No se encontro un operador valido.\n");
    return;
}

string[] numeros = ecuacion.Split(operador);

if (numeros.Length != 2)
{
    Console.WriteLine("Ingrese una operacion simple.\n");
    return;
}

if (double.TryParse(numeros[0], out double numero1) && double.TryParse(numeros[1], out double numero2))
{
    double resultado = 0;
    switch (operador)
    {
        case '+': resultado= numero1 + numero2; break;
        case '-': resultado= numero1 - numero2; break;
        case '*': resultado = numero1 * numero2; break;
        case '/':
            if (numero2 != 0)
            {
               resultado= numero1 / numero2;
            }
            else
            {
                Console.WriteLine("No es posible dividir por 0.\n");
                return;
            }
            break;
    }
    Console.WriteLine($"El resultado es: {resultado}");
}
else
{
    Console.WriteLine("Ingrese numeros validos.\n");
}

