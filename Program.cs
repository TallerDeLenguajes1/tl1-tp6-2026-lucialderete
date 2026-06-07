/*using System;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);


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
*/


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

Console.WriteLine("Fin del programa uwu");
