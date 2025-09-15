using System;

public class Ejercicio3
{
    public static void Main(string[] args)
    {
        Console.Write("Introduce un numero para ver su tabla de multiplicar: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}