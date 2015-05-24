
namespace AbstractShape 
{
    using System;

    public abstract class Shape : ICalculateSurface
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }


        public double Width
        {
            get { return this.width; }
            set 
            {
                if (value <=0)
                {
                    throw new ArgumentNullException("Width must be greater than 0.");
                }

                this.width = value; 
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Height must be grater than 0");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
        
    }
}
