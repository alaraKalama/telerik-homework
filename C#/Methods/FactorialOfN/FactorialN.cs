using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to calculate n! for each n in the range [1..100].

namespace FactorialOfN
{
    class FactorialN
    {
        static void Main()
        {
            Console.WriteLine("Enter number in the range 1 - 100:");
            decimal n = decimal.Parse(Console.ReadLine());
            if (n >= 1 && n <= 100)
            {
                Console.WriteLine("{0}! = {1}", n, CalculateFactorial(n));
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        static decimal CalculateFactorial (decimal n)
        {
            if (n == 1)
            {
                return 1; // bottom of recursion
            }
            else
            {
                return n * CalculateFactorial(n - 1); //recursion
            }
        }
    }
}
