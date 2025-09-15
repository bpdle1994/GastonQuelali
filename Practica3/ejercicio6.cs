using System;

public class Ejercicio6
{
    public static void Main(string[] args)
    {
        int[] arreglo = { 10, 5, 17, 22, 1, 9, 30, 15, 8, 20 };

        Console.Write("Ingrese un número: ");
        int numeroBuscado = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == numeroBuscado)
            {
                Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {i}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"El número {numeroBuscado} no se encuentra en el arreglo.");
        }
    }
}