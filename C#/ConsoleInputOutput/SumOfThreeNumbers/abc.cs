//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

namespace SumOfThreeNumbers
{
    class abc
    {
        static void Main()
        {
            Console.WriteLine("Enter number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c:");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sum);
        }
    }
}
