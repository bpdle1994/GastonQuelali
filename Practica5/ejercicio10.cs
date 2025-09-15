using System;
using System.Collections.Generic;

public class Ejercicio10
{
    public static void Main(string[] args)
    {
        int[] candidates = { 2, 3, 6, 7 };
        int target = 7;
        var result = CombinationSum(candidates, target);
        Console.WriteLine($"Subconjuntos para target={target}:");
        foreach (var list in result)
        {
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }
    }

    public static IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        Backtrack(result, new List<int>(), candidates, target, 0);
        return result;
    }

    private static void Backtrack(IList<IList<int>> list, IList<int> tempList, int[] nums, int remain, int start)
    {
        if (remain < 0) return;
        else if (remain == 0) list.Add(new List<int>(tempList));
        else
        {
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                Backtrack(list, tempList, nums, remain - nums[i], i);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}