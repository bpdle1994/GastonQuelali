using System;

public class Ejercicio2
{
    public static int SumaRecursiva(int n)
    {
        if (n == 0)
            return 0;
        return n + SumaRecursiva(n - 1);
    }
}