using System;

public class Ejercicio8
{
    public static void Main(string[] args)
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 0;
        int index = SearchInRotatedArray(nums, target);
        Console.WriteLine($"El elemento {target} se encuentra en la posición: {index}");
    }

    public static int SearchInRotatedArray(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[left] <= nums[mid])
            {
                if (target >= nums[left] && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                if (target > nums[mid] && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return -1;
    }
}