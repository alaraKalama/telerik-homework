//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
using System;

namespace CalculateDevideFactoriel
{
    class FactorielNAndK
    {
        static void Main()
        {
            Console.Write("Enter n:");
            ushort n = ushort.Parse(Console.ReadLine());
            Console.Write("Enter k:");
            ushort k = ushort.Parse(Console.ReadLine());
            int nFactorial = 1;
            int kFactorial = 1;
            decimal sum = 1m;

            if ((1 < k) && (k < n) && (n < 100))
            {
                for (int i = 1; i <= n; i++)
                {
                    nFactorial *= i;
                }
                for (int j = 1; j <= k; j++)
                {
                    kFactorial *= j;
                }

                    sum = (nFactorial / kFactorial);
                Console.WriteLine("n! = {0}", nFactorial);
                Console.WriteLine("k! = {0}", kFactorial);
                Console.WriteLine("n!/k! = {0}", sum);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
