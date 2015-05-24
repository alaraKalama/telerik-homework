namespace AbstractShape
{
    class Rectangle : Shape, ICalculateSurface
    {
        public Rectangle(double width, double height)
            : base (width, height)
        {

        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }


    }
}
