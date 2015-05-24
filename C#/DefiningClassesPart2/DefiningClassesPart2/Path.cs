

namespace Space3D
{
    using System;
    using System.Collections.Generic;
    //using System.Linq;
    //using System.Text;
   // using System.Threading.Tasks;

    public class Path3D
    {
        private List<Point3D> path;

        public Path3D()
        {
            this.path = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.path.Add(point);
        }

        public void DeletePoint(Point3D point)
        {
            this.path.Remove(point);
        }

        public int Count
        {
            get { return this.path.Count; }
        }

        public Point3D this[int index]
        {
            get 
            { 
                return this.path[index]; 
            }
            set 
            {
                this.path[index] = value; 
            }
        }

        public override string ToString()
        {
            return String.Join(" -> ", this.path);
        }

        public static double PathDistance(Path3D path)
        {
            int pointsCount = path.Count;
            double distance = 0;
            for (int i = 0; i < pointsCount - 1; i++)
            {
                distance += CalculateDistance.Distance(path[i], path[i + 1]);
            }
            return distance;
        }

    }
}
