using System;
using System.Collections.Generic;

class Result
{
    public static int pickingNumbers(List<int> a)
    {
        int[] count = new int[100];

        foreach (int num in a)
        {
            count[num]++;
        }

        int maxLength = 0;
        for (int i = 1; i < 100; i++)
        {
            int length = count[i] + count[i - 1];
            if (length > maxLength)
            {
                maxLength = length;
            }
        }

        return maxLength;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        Console.WriteLine(result);
    }
}
