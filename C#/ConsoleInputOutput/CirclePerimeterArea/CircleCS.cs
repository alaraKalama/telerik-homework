//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

namespace CirclePerimeterArea
{
    class CircleCS
    {
        static void Main()
        {
            Console.WriteLine("Enter radius r of the circle:");
            double r = double.Parse(Console.ReadLine());

            double C = Math.PI * 2 * r;
            double S = Math.PI * (r * r);

            Console.WriteLine("Circle perimeter: {0:F2}", C);
            Console.WriteLine("Circle area: {0:F2}", S);
        }
    }
}
