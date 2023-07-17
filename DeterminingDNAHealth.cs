using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> genes = Console.ReadLine().TrimEnd().Split(' ').ToList();

        List<int> health = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(healthTemp => Convert.ToInt32(healthTemp)).ToList();

        int s = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> totalHealths = new List<long>(); // Store the total healths of each DNA strand

        for (int sItr = 0; sItr < s; sItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int first = Convert.ToInt32(firstMultipleInput[0]);

            int last = Convert.ToInt32(firstMultipleInput[1]);

            string d = firstMultipleInput[2];

            long totalHealth = 0;

            // Iterate through the genes and check if they occur in the DNA strand
            for (int i = 0; i < n; i++)
            {
                int geneHealth = health[i];
                string gene = genes[i];

                // Check if the gene occurs in the DNA strand within the specified range
                for (int j = first; j <= last - gene.Length + 1; j++)
                {
                    if (j + gene.Length <= d.Length && d.Substring(j, gene.Length) == gene)
                    {
                        totalHealth += geneHealth;
                    }
                }
            }

            totalHealths.Add(totalHealth);
        }

        long minHealth = totalHealths.Min();
        long maxHealth = totalHealths.Max();

        Console.WriteLine($"{minHealth} {maxHealth}");
    }
}
