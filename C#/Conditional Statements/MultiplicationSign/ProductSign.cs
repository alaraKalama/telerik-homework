//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

namespace MultiplicationSign
{
    class ProductSign
    {
        static void Main()
        {
            Console.WriteLine("Enter number a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c:");
            double c = double.Parse(Console.ReadLine());
            int i = 0;

            //whenever you multiply anyting with 0 the result is zero,
            //so if we have one of the input numbers to be zero the result is going to be 0.
            if ((a == 0) || (b == 0) || (c == 0))
            {
                Console.WriteLine("Result is 0.");
            }
                // otherwise +*+*+ = +     you can see that if you i++ whenever a number
                //           +*-*- = +     is negative you will always have i % 2 == 0
                //           +*+*- = -     when the result is a positive number. And 
                //           -*-*- = -     i % 2 != 0 when result is negative. So...
            else
            {
                if (a < 0)
                {
                    i++;
                }
                if (b < 0)
                {
                    i++;
                }
                if (c < 0)
                {
                    i++;
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine("Result is +");
                }
                else
                {
                    Console.WriteLine("Result is -");
                }
            }
        }
    }
}
