using System;

public class Ejercicio2
{
    public static void Main(string[] args)
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int maxSum = MaxSubArraySum(nums);
        Console.WriteLine($"La suma máxima del subarreglo es: {maxSum}");
    }

    public static int MaxSubArraySum(int[] nums)
    {
        int max_so_far = nums[0];
        int max_ending_here = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            max_ending_here = Math.Max(nums[i], max_ending_here + nums[i]);
            max_so_far = Math.Max(max_so_far, max_ending_here);
        }
        return max_so_far;
    }
}