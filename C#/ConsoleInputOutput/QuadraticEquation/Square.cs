//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

namespace QuadraticEquation
{
    class Square
    {
        static void Main()
        {
            Console.WriteLine("Solving quadrativ equation ax^2 + bx + c = 0");
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());
            // the equation shoul look like this:
            // (x * x) + (b / a) * x + (b / (2 * a) * (b / (2 * a) = -(c / a) - (b / (2 * a))
            // left side of the equasion is perfect root:
            // (x + (b / (2*a))) * (x + (b / (2*a))) = (b * b) - (4 * a * c) / 4 * a * a
            // x = (Math.Sqrt(b * b) - 4 * a * c) / (2 * a) - b / (2 * a)
            double e = (b * b) - 4 * a * c;

            if (e < 0)
            {
                Console.WriteLine("There are no real roots.");
            }
            else
            {
                double eRoot = Math.Sqrt(e);
                double x1 = (-b - eRoot) / (2 * a);
                double x2 = (-b + eRoot) / (2 * a);
                if (x1 == x2)
                {
                    Console.WriteLine("x1=x2={0}", x1);
                }
                else
                {
                    Console.WriteLine("x1 = {0} \nx2 = {1}", x1, x2);
                }
                
            }

           
        }
    }
}
