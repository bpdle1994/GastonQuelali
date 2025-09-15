using System;

public class Ejercicio6
{
    public static void Main(string[] args)
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        int[,] transposed = TransposeMatrix(matrix);
        Console.WriteLine("Matriz transpuesta:");
        PrintMatrix(transposed);
    }

    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}