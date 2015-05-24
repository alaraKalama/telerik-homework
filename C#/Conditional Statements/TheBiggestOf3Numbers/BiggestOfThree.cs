//Write a program that finds the biggest of three numbers.
using System;

namespace TheBiggestOf3Numbers
{
    class BiggestOfThree
    {
        static void Main()
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());

            if (a > b && b > c)
            {
                Console.WriteLine("The biggest of the three is {0}", a);
            }
            if (b > a && a > c)
            {
                Console.WriteLine("The biggest of the three is {0}", b);
            }
            else
            {
                Console.WriteLine("The biggest of the three is {0}", c);
            }


        }
    }
}
