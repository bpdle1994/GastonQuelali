using System;

public class Ejercicio10
{
    public static string DecimalABinarioRecursivo(int n)
    {
        if (n == 0)
            return "";
        return DecimalABinarioRecursivo(n / 2) + (n % 2);
    }
}