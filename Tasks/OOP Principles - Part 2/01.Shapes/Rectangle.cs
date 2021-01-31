using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double _width = 0, double _height = 0)
        {
            width = _width;
            height = _height;
        }

        public override double CalculateSurface()
        {
            return width * height;
        }
    }
}
