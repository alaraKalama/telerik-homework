using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
    class StartingPoint
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(5, 8.9),
                new Rectangle(7.3, 6.2),
                new Square(6, 6)
            };

            foreach(var s in shapes)
            {
                Console.WriteLine("{0} with width {1} and height {2} has surface: {3}",
                    s.GetType(), s.Width, s.Height, s.CalculateSurface());
            }

        }
    }
}
