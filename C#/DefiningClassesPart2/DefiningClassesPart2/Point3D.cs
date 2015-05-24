

namespace Space3D
{
    using System;
   // using System.Collections.Generic;
    //using System.Linq;
    //using System.Text;
   // using System.Threading.Tasks;

    public struct Point3D
    {
       
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        private static readonly Point3D zeroPoint;
        
        public static Point3D ZeroPoint
        {
            get
            {
                return zeroPoint;
            }
        }

        static Point3D()
        {
            zeroPoint = new Point3D(0, 0, 0);
        }

        public Point3D (double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("point [{0},{1},{2}]", this.X, this.Y, this.Z);
        }
    }
}
