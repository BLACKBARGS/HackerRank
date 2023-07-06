using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        List<int> distinctRanked = ranked.Distinct().OrderByDescending(x => x).ToList();
        int rankIndex = distinctRanked.Count - 1;
        int playerRank = distinctRanked.Count + 1;
        List<int> result = new List<int>();

        foreach (int score in player)
        {
            while (rankIndex >= 0 && score >= distinctRanked[rankIndex])
            {
                rankIndex--;
            }

            result.Add(rankIndex + 2);
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result.climbingLeaderboard(ranked, player);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
