using System;

public class Ejercicio8
{
    public static int SumaArregloRecursiva(int[] arr, int indice)
    {
        if (indice < 0)
            return 0;
        return arr[indice] + SumaArregloRecursiva(arr, indice - 1);
    }
}