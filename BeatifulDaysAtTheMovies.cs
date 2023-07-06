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

    public static int beautifulDays(int i, int j, int k)
{
    int beautifulCount = 0;

    for (int day = i; day <= j; day++)
    {
        int reverse = ReverseNumber(day);
        int difference = Math.Abs(day - reverse);

        if (difference % k == 0)
            beautifulCount++;
    }

    return beautifulCount;
}

private static int ReverseNumber(int num)
{
    int reverse = 0;

    while (num > 0)
    {
        int digit = num % 10;
        reverse = (reverse * 10) + digit;
        num /= 10;
    }

    return reverse;
}


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result.beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
