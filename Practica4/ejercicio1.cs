// Archivo: Practica4.cs

using System;
using System.Collections.Generic;

public class Practica4
{
    public static void Main(string[] args)
    {
        // 1. Declarar e inicializar una cola de enteros
        Queue<int> colaDeNumeros = new Queue<int>();

        // 2. Enqueue (Agregar elementos a la cola)
        Console.WriteLine("Agregando elementos a la cola:");
        colaDeNumeros.Enqueue(10);
        Console.WriteLine($"Agregado: 10");
        colaDeNumeros.Enqueue(20);
        Console.WriteLine($"Agregado: 20");
        colaDeNumeros.Enqueue(30);
        Console.WriteLine($"Agregado: 30");

        // 3. Peek (Ver el elemento al frente sin eliminarlo)
        Console.WriteLine($"\nEl elemento al frente de la cola es: {colaDeNumeros.Peek()}");

        // 4. Dequeue (Eliminar elementos de la cola)
        Console.WriteLine("\nEliminando elementos de la cola:");
        int elementoEliminado1 = colaDeNumeros.Dequeue();
        Console.WriteLine($"Eliminado: {elementoEliminado1}");
        int elementoEliminado2 = colaDeNumeros.Dequeue();
        Console.WriteLine($"Eliminado: {elementoEliminado2}");

        // 5. Verificar si la cola está vacía
        Console.WriteLine($"\n¿La cola está vacía? {colaDeNumeros.Count == 0}");

        // 6. Eliminar el último elemento restante
        colaDeNumeros.Dequeue();
        Console.WriteLine("Último elemento eliminado.");

        // 7. Verificar nuevamente si la cola está vacía
        Console.WriteLine($"\n¿La cola está vacía? {colaDeNumeros.Count == 0}");
    }
}