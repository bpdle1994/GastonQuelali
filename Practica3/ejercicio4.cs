using System;

public class Ejercicio4
{
    public static void Main(string[] args)
    {
        int[] notas = { 80, 70, 90, 60, 100 };
        int suma = 0;
        double promedio;

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

        promedio = (double)suma / notas.Length;
        
        Console.WriteLine($"Notas: [{string.Join(", ", notas)}]");
        Console.WriteLine($"Promedio: {promedio}");
    }
}