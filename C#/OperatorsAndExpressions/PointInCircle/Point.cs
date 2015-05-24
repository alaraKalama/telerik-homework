//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2). 

using System;

namespace PointInCircle
{
    class Point
    {
        static void Main()
        {
            Console.WriteLine("To find if a point is inside a circle, write it's coordinates x and y:");
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y:");
            int y = int.Parse(Console.ReadLine());
            int r = 2;

            bool inCircle = (x * x + y * y) <= r * r;

            if (inCircle == true)
            {
                Console.WriteLine("The point is in the circle.");
            }
            else
            {
                Console.WriteLine("The point isn't in the circle.");
            }
        }
    }
}
