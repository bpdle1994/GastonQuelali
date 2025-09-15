using System;

public class Ejercicio6
{
    public static int ContarDigitosRecursivo(int n)
    {
        if (n == 0)
            return 0;
        return 1 + ContarDigitosRecursivo(n / 10);
    }
}