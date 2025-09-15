using System;

public class Ejercicio3
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 1, 2, 2, 3, 4, 4 };
        int newLength = RemoveDuplicates(nums);
        int[] result = new int[newLength];
        Array.Copy(nums, result, newLength);
        Console.WriteLine($"Arreglo sin duplicados: [{string.Join(", ", result)}]");
    }

    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int i = 0;
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j];
            }
        }
        return i + 1;
    }
}