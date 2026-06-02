
bool continuar = true;

while (continuar == true)
{
    Console.WriteLine("--Calculadora--");
    Console.WriteLine("seleccione la operacion que desea realizar: ");
    Console.WriteLine("1) sumar");
    Console.WriteLine("2) restar");
    Console.WriteLine("3) multiplicar");
    Console.WriteLine("4) dividir");
    Console.WriteLine("0) finalizar");
    string o = Console.ReadLine();
    int opcion;

    if (int.TryParse(o, out opcion))
    {
        if (opcion >= 1 || opcion <= 5)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            string n1 = Console.ReadLine();
            int num1;

            Console.WriteLine("Ingrese el segundo numero numero: ");
            string n2 = Console.ReadLine();
            int num2;
            int resultado = 0;
            if (int.TryParse(n1, out num1) && int.TryParse(n2, out num2))
            {
                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"Reultado: {resultado} ");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Reultado: {resultado} ");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"Reultado: {resultado} ");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("error, el numero 2 no puede ser 0");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Reultado: {resultado} ");
                        }
                        break;

                }


            }

        }
        else
        {
            Console.WriteLine("ingrese una opcion valida");
        }
    }
    else
    {
        Console.WriteLine("error");
    }

    Console.WriteLine("desea realizar otro calculo? (S= si || N=no) ");
    string respuesta = Console.ReadLine().ToUpper() ??"N";
    if(respuesta != "S")
    {
        continuar = false;
    }

}

Console.WriteLine("programa finalizado");

