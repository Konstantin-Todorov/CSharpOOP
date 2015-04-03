namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ShapesMain
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5.7, 3),
                new Triangle(4, 4.7),
                new Square(4.5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0:F2}", shape.CalculateSurface());
            }
        }
    }
}
