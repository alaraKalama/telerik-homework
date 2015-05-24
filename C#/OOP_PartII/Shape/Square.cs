namespace AbstractShape
{
    using System;
    
    class Square : Shape, ICalculateSurface
    {
        public Square(double width, double height)
            : base (width, height)
        {
            if (this.Width != this.Height)
            {
                throw new ArgumentException("Square width and height must be equal!");
            }
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
