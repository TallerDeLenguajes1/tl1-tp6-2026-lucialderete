/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);
*/

Console.Write("Ingrese un numero positivo: ");
string numeroIngresado = Console.ReadLine();
int numero;
if(int.TryParse(numeroIngresado, out numero)){
    if(numero > 0){
        int invertido=0;
        while(numero > 0){
            int aux = numero;
            int resto = numero %10;
            invertido =(invertido *10)+resto;
            aux /= 10;
        }
        Console.WriteLine($"Numero invertido: {invertido}");
        Console.WriteLine($"Numero ingresado: {numero}");

    }else{
        Console.WriteLine("Ingrese un numero positivo");
    }

}else{
    Console.WriteLine("error en el numero ingresado");
}
