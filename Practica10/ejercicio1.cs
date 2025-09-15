using System;

public class Ejercicio1
{
    public static int FactorialRecursivo(int n)
    {
        if (n == 0)
            return 1;
        return n * FactorialRecursivo(n - 1);
    }
}