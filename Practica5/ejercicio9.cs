using System;
using System.Collections.Generic;

public class Ejercicio9
{
    public static void Main(string[] args)
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        var result = SpiralOrder(matrix);
        Console.WriteLine($"Recorrido en espiral: [{string.Join(", ", result)}]");
    }

    public static List<int> SpiralOrder(int[,] matrix)
    {
        var result = new List<int>();
        if (matrix.Length == 0) return result;

        int rowStart = 0, rowEnd = matrix.GetLength(0) - 1;
        int colStart = 0, colEnd = matrix.GetLength(1) - 1;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            // Derecha
            for (int j = colStart; j <= colEnd; j++)
            {
                result.Add(matrix[rowStart, j]);
            }
            rowStart++;

            // Abajo
            for (int i = rowStart; i <= rowEnd; i++)
            {
                result.Add(matrix[i, colEnd]);
            }
            colEnd--;

            // Izquierda
            if (rowStart <= rowEnd)
            {
                for (int j = colEnd; j >= colStart; j--)
                {
                    result.Add(matrix[rowEnd, j]);
                }
            }
            rowEnd--;

            // Arriba
            if (colStart <= colEnd)
            {
                for (int i = rowEnd; i >= rowStart; i--)
                {
                    result.Add(matrix[i, colStart]);
                }
            }
            colStart++;
        }
        return result;
    }
}