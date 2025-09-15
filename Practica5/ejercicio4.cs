using System;

public class Ejercicio4
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 4, 5, 6 };
        int missingNumber = FindMissingNumber(nums);
        Console.WriteLine($"El número que falta es: {missingNumber}");
    }

    public static int FindMissingNumber(int[] nums)
    {
        int n = nums.Length + 1;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;
        foreach (int num in nums)
        {
            actualSum += num;
        }
        return expectedSum - actualSum;
    }
}