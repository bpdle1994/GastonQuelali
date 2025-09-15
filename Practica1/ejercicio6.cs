using System;

public class Ejercicio6
{
    public static void Main(string[] args)
    {
        int numero;

        do
        {
            Console.Write("Introduce un numero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());
        } while (numero <= 0);

        Console.WriteLine($"Numero ingresado: {numero}. ¡Es un numero positivo!");
    }
}