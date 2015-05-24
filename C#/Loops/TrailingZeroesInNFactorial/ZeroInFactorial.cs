using System;
using System.Numerics;

namespace TrailingZeroesInNFactorial
{
    class ZeroInFactorial
    {
        static void Main()
        {
            Console.WriteLine("Enter n:");
            long n = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            long counter = 0;

            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            BigInteger tempFactorial = nFactorial;

            while (tempFactorial % 10 == 0)
            {
                counter++;
                tempFactorial /= 10;
            }

            Console.WriteLine("Factorial of input: {0} - it has {1} zeroes", nFactorial, counter);
        }
    }
}
