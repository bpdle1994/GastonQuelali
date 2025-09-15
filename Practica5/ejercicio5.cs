using System;
using System.Collections.Generic;

public class Ejercicio5
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 2, 1 };
        int[] arr2 = { 2, 2 };
        int[] intersection = FindIntersection(arr1, arr2);
        Console.WriteLine($"Intersección: [{string.Join(", ", intersection)}]");
    }

    public static int[] FindIntersection(int[] arr1, int[] arr2)
    {
        var result = new List<int>();
        var seen = new Dictionary<int, int>();

        foreach (var num in arr1)
        {
            if (seen.ContainsKey(num))
                seen[num]++;
            else
                seen.Add(num, 1);
        }

        foreach (var num in arr2)
        {
            if (seen.ContainsKey(num) && seen[num] > 0)
            {
                result.Add(num);
                seen[num]--;
            }
        }
        return result.ToArray();
    }
}