using System;

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
