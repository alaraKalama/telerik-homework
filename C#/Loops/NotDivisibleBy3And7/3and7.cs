//Write a program that enters from the console a positive integer n 
//and prints all the numbers from 1 to n not divisible by 3 and 7,
//on a single line, separated by a space.

using System;

namespace NotDivisibleBy3And7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
                {
                    Console.Write("{0} ", i);
                }
                
            }
        }
    }
}
