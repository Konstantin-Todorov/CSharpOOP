namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width,double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get { return this.height; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentNullException();
                }
                this.height = value; 
            }
        }
        
        public double Width
        {
            get { return this.width; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentNullException();
                }
                this.width = value; 
            }
        }

        public abstract double CalculateSurface();
    }
}
