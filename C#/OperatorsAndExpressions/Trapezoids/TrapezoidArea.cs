//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

namespace Trapezoids
{
    class TrapezoidArea
    {
        static void Main()
        {
            //first we ask for the sides and height
            Console.WriteLine("Enter trapezoid side a and press Enter:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter trapezoid side b and press Enter:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter trapezoid height and press Enter:");
            double h = double.Parse(Console.ReadLine());

            double area = 0.5 * (a + b) * h;
            Console.WriteLine("Trapezoid area is {0}", area);
        }
    }
}
