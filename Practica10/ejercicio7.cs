using System;

public class Ejercicio7
{
    public static int MCDRecursivo(int a, int b)
    {
        if (b == 0)
            return a;
        return MCDRecursivo(b, a % b);
    }
}