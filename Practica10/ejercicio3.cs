using System;

public class Ejercicio3
{
    public static int FibonacciRecursivo(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
    }
}