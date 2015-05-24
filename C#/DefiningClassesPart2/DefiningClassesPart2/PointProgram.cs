namespace Space3D
{
    using System;
//    using System.Collections.Generic;
  //  using System.Linq;
   // using System.Text;
  //  using System.Threading.Tasks;

    class PointProgram
    {
        static void Main()
        {
            //create two points and calculate the distance between them:
            Point3D pointA = new Point3D(9, 8, 4);
            Point3D pointB = new Point3D(12, 2, 5);
            double distance = CalculateDistance.Distance(pointA, pointB);
            Console.WriteLine("The distance between the two points is: {0:F2}", distance);
            Console.WriteLine();

            //create a path and add some points:
            Path3D path = new Path3D();
            path.AddPoint(pointA);
            path.AddPoint(pointB);
            path.AddPoint(new Point3D(6, 8, 2));
            path.AddPoint(Point3D.ZeroPoint);

            //print the path and calculate the distance between all points in it:
            Console.WriteLine("Your path is:");
            Console.WriteLine(path.ToString());
            Console.WriteLine();
            double pathDistance = Path3D.PathDistance(path);
            Console.WriteLine("The distance between all points in the path is: {0:F2}", pathDistance);
            Console.WriteLine();

            //save the path
            Console.WriteLine("Saving the path to files:");
            PathStorage.Save(path);
            Console.WriteLine();

            //load a path:
            Path3D newPath = PathStorage.Load();
            Console.WriteLine("Loaded path is:");
            Console.WriteLine(newPath.ToString());

        }
    }
}
