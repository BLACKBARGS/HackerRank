using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int hurdleRace(int k, List<int> height)
    {
        int maxHurdleHeight = height.Max();

        if (maxHurdleHeight <= k)
        {
            return 0;
        }
        else
        {
            int additionalHeight = maxHurdleHeight - k;
            return additionalHeight;
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

        int result = Result.hurdleRace(k, height);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
