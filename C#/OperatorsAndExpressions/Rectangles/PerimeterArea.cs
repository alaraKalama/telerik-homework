//Write an expression that calculates rectangle’s perimeter and area by given width and height
using System;

namespace Rectangles
{
    class PerimeterArea
    {
        static void Main()
        {
            Console.WriteLine("To calculate a rectangle perimeter and area, please enter");
            Console.WriteLine("a real number for the rectangle's width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("and a real number for it's hight:");
            int hight = int.Parse(Console.ReadLine());
            int perimeter = width * 2 + hight * 2;
            int area = width * hight;
            Console.WriteLine("A rectangle with width - {0}cm and hight - {1}cm, has a perimeter of {2}cm, and area of {3}cm3", width, hight, perimeter, area);
        }
    }
}
