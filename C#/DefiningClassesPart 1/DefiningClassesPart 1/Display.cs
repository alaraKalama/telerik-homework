using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart_1
{
    public class Display //1.
    {
        private double size;
        private int numberOfColors;

        //5. properties:
        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

        //2. constructors:
        public Display (double size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public Display(double size)
        {
            this.size = size;
        }

        public Display(int numberOfColors)
        {
            this.numberOfColors = numberOfColors;
        }

        public Display()
        {

        }

        public string DisplayDisplayInfo(Display display)
        {
            string info = string.Empty;
            StringBuilder infoBuild = new StringBuilder();
            infoBuild.Append("Display:\n");
            if (display.NumberOfColors <= 0)
            {
                throw new ArgumentNullException("Number of colors can't be zero.");
            }
            if (display.NumberOfColors != null)
            {
                infoBuild.Append(display.NumberOfColors + "M colors" + "\n");
            }

            if (display.Size != null)
            {
                infoBuild.Append(display.Size + "inches" + "\n");
            }

            info = infoBuild.ToString();
            return info;
        }

    }
}
