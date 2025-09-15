using System;

public class Ejercicio2
{
    public static void Main(string[] args)
    {
        Console.Write("Introduce un numero N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int suma = 0;
        int contador = 1;

        while (contador <= n)
        {
            suma += contador;
            contador++;
        }

        Console.WriteLine($"La suma de los numeros del 1 al {n} es: {suma}");
    }
}