using System;

public class Ejercicio10
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 51);
        int intento;

        Console.WriteLine("¡Adivina el numero entre 1 y 50!");

        do
        {
            Console.Write("Introduce tu intento: ");
            intento = Convert.ToInt32(Console.ReadLine());

            if (intento > numeroAleatorio)
            {
                Console.WriteLine("El numero es menor.");
            }
            else if (intento < numeroAleatorio)
            {
                Console.WriteLine("El numero es mayor.");
            }
        } while (intento != numeroAleatorio);

        Console.WriteLine($"¡Felicidades! Adivinaste el numero {numeroAleatorio}.");
    }
}