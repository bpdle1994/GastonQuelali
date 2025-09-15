using System;

public class Ejercicio9
{
    public static void Main(string[] args)
    {
        int contador = 0;
        int numero = 2;

        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2;
            contador++;
        }
    }
}