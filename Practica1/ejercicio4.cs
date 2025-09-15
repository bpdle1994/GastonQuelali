using System;

public class Ejercicio4
{
    public static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Hola!");
                    break;
                case 2:
                    Console.Write("Introduce el primer numero: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Introduce el segundo numero: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"La suma es: {num1 + num2}");
                    break;
                case 3:
                    Console.WriteLine("Adios!");
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
            Console.WriteLine();
        } while (opcion != 3);
    }
}