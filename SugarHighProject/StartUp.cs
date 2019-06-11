namespace SugarHighProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] candies;

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                candies = new int[0];
            }
            else
            {
                candies = input
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
            }

            int threshold = int.Parse(Console.ReadLine());

            var result = SugarHigh(candies, threshold);

            Console.WriteLine(string.Join(" ", result));
        }

        public static int[] SugarHigh(int[] candies, int threshold)
        {
            var result = new SortedSet<int>();

            int[] remainingCandies = new int[candies.Length];
            candies.CopyTo(remainingCandies, 0);

            var sortedCandies = new List<int>(candies);
            sortedCandies.Sort();

            int sugerSum = 0;

            for (int i = 0; i < sortedCandies.Count; i++)
            {
                int currentCandySuger = sortedCandies[i];

                if (sugerSum + currentCandySuger <= threshold)
                {
                    sugerSum += currentCandySuger;

                    int sugerIndex = Array.IndexOf(remainingCandies, currentCandySuger);
                    remainingCandies[sugerIndex] = -1;

                    result.Add(sugerIndex);
                }
                else
                {
                    break;
                }
            }

            return result.ToArray();
        }
    }
}
