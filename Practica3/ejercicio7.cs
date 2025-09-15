using System;

public class Ejercicio7
{
    public static void Main(string[] args)
    {
        int[] arreglo = { 2, 5, 2, 8, 2, 9 };
        int contador = 0;

        Console.Write("Número buscado: ");
        int numeroBuscado = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == numeroBuscado)
            {
                contador++;
            }
        }
        Console.WriteLine($"El número aparece {contador} veces");
    }
}