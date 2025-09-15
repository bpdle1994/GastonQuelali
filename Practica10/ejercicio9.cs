using System;

public class Ejercicio9
{
    public static bool BuscarElementoRecursivo(int[] arr, int valor, int indice)
    {
        if (indice >= arr.Length)
            return false;
        if (arr[indice] == valor)
            return true;
        return BuscarElementoRecursivo(arr, valor, indice + 1);
    }
}