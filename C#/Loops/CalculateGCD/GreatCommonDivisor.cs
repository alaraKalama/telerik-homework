//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
using System;

namespace CalculateGCD
{
    class GreatCommonDivisor
    {
        static void Main()
        {
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = int.Parse(Console.ReadLine());
            int gcd = 1;
            int tempA = a;
            int tempB = b;
           // if (a < b)
            //{
              //  tempA = b;
                //tempB = a;
            //}
            int c = 1;

            if (tempA == 0)
            {
                gcd = b;
            }
            else if (tempB == 0)
            {
                gcd = a;
            }
            while (tempA != 0 && tempB != 0)
            {
                c = tempA % tempB;
                tempA = tempB;
                tempB = c;

                if (tempA == 0)
                {
                    gcd = tempB;
                }
                else if (tempB == 0)
                {
                    gcd = tempA;
                }
            }
            Console.WriteLine("GCD: {0}", gcd);

        }
    }
}
