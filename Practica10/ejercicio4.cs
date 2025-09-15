using System;

public class Ejercicio4
{
    public static int PotenciaRecursiva(int baseNum, int exp)
    {
        if (exp == 0)
            return 1;
        return baseNum * PotenciaRecursiva(baseNum, exp - 1);
    }
}