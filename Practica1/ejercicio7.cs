using System;

public class Ejercicio7
{
    public static void Main(string[] args)
    {
        int suma = 0;
        int numero;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Introduce el numero {i + 1}: ");
            numero = Convert.ToInt32(Console.ReadLine());
            suma += numero;
        }

        Console.WriteLine($"La suma total es: {suma}");
    }
}