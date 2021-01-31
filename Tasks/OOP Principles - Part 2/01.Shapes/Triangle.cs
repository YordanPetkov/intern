using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Shapes
{
    class Triangle : Shape
    {
        public Triangle(double _width, double _height)
        {
            width = _width;
            height = _height;
        }

        public override double CalculateSurface()
        {
            return width * height / 2;
        }
    }
}
