using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
{
    int n = a.Count;

    // Calculate the effective number of rotations
    int effectiveRotations = k % n;

    // Create a new list to store the rotated array
    List<int> rotatedArray = new List<int>();

    // Perform the rotations and update the indices
    for (int i = 0; i < n; i++)
    {
        int newIndex = (i + n - effectiveRotations) % n;
        rotatedArray.Add(a[newIndex]);
    }

    // Retrieve the values at the given indices
    List<int> result = new List<int>();
    foreach (int query in queries)
    {
        result.Add(rotatedArray[query]);
    }

    return result;
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

        int q = Convert.ToInt32(firstMultipleInput[2]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> queries = new List<int>();

        for (int i = 0; i < q; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<int> result = Result.circularArrayRotation(a, k, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
