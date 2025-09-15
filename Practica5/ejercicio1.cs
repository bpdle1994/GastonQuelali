using System;
using System.Linq;

public class Ejercicio1
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        int k = 2;
        Rotate(nums, k);
        Console.WriteLine($"Arreglo rotado: [{string.Join(", ", nums)}]");
    }

    public static void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n;
        Array.Reverse(nums, 0, n);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, n - k);
    }
}