//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

namespace CalculateCombinations
{
    class CombinationFormula
    {
        static void Main()
        {
            Console.Write("Enter n:");
            ushort n = ushort.Parse(Console.ReadLine());
            Console.Write("Enter k:");
            ushort k = ushort.Parse(Console.ReadLine());
            BigInteger nOverKFact = 1;
            BigInteger nMinusKFact = 1;
            BigInteger sum = 1;
            int difference = n - k; 

            if ((1 < k) && (k < n) && (n < 100))
            {
                for (int i = k + 1; i <= n; i++)
                {
                    nOverKFact *= i;
                }
                for (int y = 1; y <= difference; y++)
                {
                    nMinusKFact *= y;
                }
                sum = nOverKFact / nMinusKFact;
                Console.WriteLine("Combinations: {0}", sum);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
