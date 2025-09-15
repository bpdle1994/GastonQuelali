using System;

public class Ejercicio5
{
    public static string InvertirCadenaRecursivo(string cadena)
    {
        if (string.IsNullOrEmpty(cadena))
            return cadena;
        return InvertirCadenaRecursivo(cadena.Substring(1)) + cadena[0];
    }
}