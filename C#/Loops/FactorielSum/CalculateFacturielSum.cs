/*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
 * Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;
using System.Numerics;

namespace FactorielSum
{
    class CalculateFacturielSum
    {
        static void Main()
        {
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x:");
            int x = int.Parse(Console.ReadLine()); ;

            int nFactorial = 1;
            decimal sum = 1m;
            decimal power = 1m;

            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                power *= x;
                sum += (nFactorial / power);
            }

            Console.WriteLine("\nsum: {0:F5}", sum);
        }
    }
}
