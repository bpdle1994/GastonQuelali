using System;

public class Ejercicio8
{
    public static void Main(string[] args)
    {
        Console.Write("Introduce un numero para saber si es primo: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        bool esPrimo = true;

        if (numero <= 1)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
        {
            Console.WriteLine($"{numero} es un numero primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un numero primo.");
        }
    }
}