﻿namespace AbstractShape
{
    class Triangle : Shape, ICalculateSurface
    {
        public Triangle(double width, double height)
            : base(width, height)
        {

        }
         
        public override double CalculateSurface()
        {
            return this.Width * this.Height / 2;
        }
    }
}
