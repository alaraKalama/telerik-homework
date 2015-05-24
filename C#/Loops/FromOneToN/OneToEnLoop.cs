//Write a program that enters from the console a positive integer n 
//and prints all the numbers from 1 to n, on a single line, separated by a space.
using System;

namespace FromOneToN
{
    class OneToEnLoop
    {
        static void Main()
        {
            Console.WriteLine("Enter a real positive number:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
