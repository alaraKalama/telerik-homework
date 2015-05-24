//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

namespace CircleRectanglePoint
{
    class Point
    {
        static void Main()
        {
            Console.WriteLine("Enter point P coordinates to check if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).");
            
            //first we enter the coordinates(x, y) of the point P we are looking for:
            Console.WriteLine("Enter coordinate x and press Enter:");
            double xp = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y and press Enter:");
            double yp = double.Parse(Console.ReadLine());
           
            //the radius of the circle is 1.5
            double r = 1.5f;
            
            //this formula gives us is the point is in the circle. If bool is true - the point is in the circle.
            bool inCircle = (xp - 1) * (xp - 1) + (yp - 1) * (yp - 1) <= r * r;
           
            //now we have to define out reactangular ABCD -
            //from what we have in the condition we can tell that the four points of the rectangle are:
            //A(-1,1), B(-1,-1), C(5,1), D(5,-1); and AB = CD = 2, AC = BD = 6
            //the area of the rectangular is 12 cubic cm(is we agree we work with cm)
            double recArea = 12;
            //if we create 4 triangles with the new point P(ABP, APC, BPD and DPC) and the sum of
            //the areas of those triangles is equal to the area of the rectangle ABCD - 
            //point P should be inside the triangle.
            //But first we have to find the lenght of the lines from P to all the other points A,B,C and D.
            //Lenght of PA line:
            double linePAsqrt = (xp + 1) * (xp + 1) + (yp - 1) * (yp - 1);
            double linePA = Math.Sqrt(linePAsqrt);
            //Lenght of PB line:
            double linePBsqrt = (xp + 1) * (xp + 1) + (yp + 1) * (yp + 1);
            double linePB = Math.Sqrt(linePBsqrt);
            //Lenght of PC line:
            double linePCsqrt = (xp - 5) * (xp - 5) + (yp + 1) * (yp + 1);
            double linePC = Math.Sqrt(linePCsqrt);
            //Lenght of PD line:
            double linePDsqrt = (xp -5) * (xp - 5) + (yp + 1) * (yp + 1);
            double linePD = Math.Sqrt(linePDsqrt);

            //To calculate the area of the triangles we will need one more constant - the height of the triangle.
            //If we asume the lines of the rectangle are the bases of the triangles, the heights are going to be lines
            //from point P to a point in the lines - to establish this points for lines BD and AC, we have to keep 
            //the coordinates of axys x the same as the coordinates of P, and change the coordinates of axys y
            //to -1 for line BD and to 1 for line AC. The opposite will happen for lines AB and CD - we keep the coordinate 
            //of axys y, and change the coordinates of axys x to -1 for line AB, and to 5 for line CD. So...
             double heightABPsqrt = (xp + 1) * (xp + 1) + (yp - yp) * (yp - yp); //this is always going to be zero.
             double heightABP = Math.Sqrt(heightABPsqrt);
             double heightCDPsqrt = (xp - 5) * (xp - 5);
             double heightCDP = Math.Sqrt(heightCDPsqrt);
             double heightACPsqrt = (yp - 1) * (yp - 1);
             double heightACP = Math.Sqrt(heightACPsqrt);
             double heightBDPsqrt = (yp + 1) * (yp + 1);
             double heightBDP = Math.Sqrt(heightBDPsqrt);

            //Now that we know the heights, we can calculate the areas of the triangles:
            //Area of triangle ABP:
             double areaABP = 0.5 * 2 * heightABP;
             double areaCDP = 0.5 * 2 * heightCDP;
             double areaACP = 0.5 * 6 * heightACP;
             double areaBDP = 0.5 * 6 * heightBDP;
             
            //Now create another bool to check if the areas of all the triangles are equal to the area of the rectangle.
             bool inRectangle = areaABP + areaACP + areaBDP + areaCDP == recArea;
             bool inCircleOutRec = inCircle == true && inRectangle == false;

             Console.WriteLine("The point is in the circle ---> {0}", inCircle);
             Console.WriteLine("The point is in the rectangle ---->{0}", inRectangle);
             Console.WriteLine("The point is in the circle and outside of the rectangle ---> {0}", inCircleOutRec);

            //Apperantly there is much shorter way to do this, but I come up with this:)
        }
    }
}