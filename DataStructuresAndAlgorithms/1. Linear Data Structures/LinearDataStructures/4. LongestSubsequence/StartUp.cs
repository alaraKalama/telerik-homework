namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Write a method that finds the longest subsequence of equal numbers in given List 
    // and returns the result as new List<int>.
    // Write a program to test whether the method works correctly.

    public class StartUp
    {
        public static void Main()
        {
            IList<int> sequence = new List<int> { 3, 4, 5, 5, 5, 5, 5, 3, 2, 1, 1, 4 };
            List<int> subsequence = FindLongestSubsequence(sequence);
            Console.WriteLine("Longest subsequence of equal numbers: {0}", String.Join(", ", subsequence));
        }

        public static List<int> FindLongestSubsequence(IList<int> sequence)
        {
            var subsequence = new Dictionary<int, int>();
            int bestKey = 0;
            int bestValue = 0;

            foreach(var number in sequence)
            {
                if(!subsequence.ContainsKey(number))
                {
                    subsequence.Add(number, 0);
                }

                subsequence[number]++;

                if(subsequence[number] > bestValue)
                {
                    bestValue = subsequence[number];
                    bestKey = number;
                }
            }
            return Enumerable.Repeat(bestKey, bestValue).ToList();
        }
    }
}
