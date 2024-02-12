// See https://aka.ms/new-console-template for more information
Console.WriteLine("PAR O IMPAR");

Console.WriteLine();

{
    
    Console.WriteLine("Ingrese un número:");
    int numero = Convert.ToInt32(Console.ReadLine());

   
    if (numero % 2 == 0)
    {
        Console.WriteLine("El número ingresado es par.");
    }
    else
    {
        Console.WriteLine("El número ingresado es impar.");
    }
}