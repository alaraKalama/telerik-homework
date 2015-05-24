using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class FindPrimes
    {
        static void Main()
        {
            Console.WriteLine
                ("For the sake of simplicity and time saving enter a number to which you wish to count primes");
            Console.WriteLine("The bigger the number, the slower the program");
            int n = int.Parse(Console.ReadLine());
            int[] lotsOfNumbers = Enumerable.Range(2, n - 1).ToArray();

            for (int i = 0; i < Math.Sqrt(n); i++)
            {
                if (lotsOfNumbers[i] != 0)
                {
                    for (int j = i + 1; j < lotsOfNumbers.Length; j++)
                    {
                        if (lotsOfNumbers[j] % lotsOfNumbers[i] == 0)
                        {
                            lotsOfNumbers[j] = 0;
                        }
                    }
                }
            }

            int zeroes = 0;
            int[] Primes = lotsOfNumbers.Where(val => val != zeroes).ToArray();

            int numberOfPrimes = Primes.Length;


            for (int i = 0; i < Primes.Length; i++)
            {
                Console.Write("{0} ", Primes[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Number of primes from 1 to {0} = {1}", n, numberOfPrimes);
        }

       
    }
}
