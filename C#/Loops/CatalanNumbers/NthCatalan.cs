//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

namespace CatalanNumbers
{
    class NthCatalan
    {
        static void Main()
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            BigInteger a = 1;
            BigInteger b = 1;

            if (n >= 0 && n <= 100)
            {
                for (int i = 2 * n; i > n + 1; i--)
                {
                    a *= i;
                }
                for (int j = 1; j <=n; j++)
                {
                    b *= j;
                }
                BigInteger result = a / b;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Ivalid input!");
            }
        }
    }
}
