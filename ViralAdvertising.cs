class Result
{
    public static int viralAdvertising(int n)
    {
        int shared = 5; // Initial number of people who receive the advertisement
        int liked = 0; // Number of people who like the advertisement
        int cumulativeLikes = 0; // Cumulative number of likes

        for (int i = 1; i <= n; i++)
        {
            liked = shared / 2; // Number of people who like the advertisement on the current day
            cumulativeLikes += liked; // Update the cumulative number of likes
            shared = liked * 3; // Number of people who receive the advertisement on the next day
        }

        return cumulativeLikes;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int result = Result.viralAdvertising(n);
        Console.WriteLine(result);
    }
}
