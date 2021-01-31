using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Shapes
{
    abstract class Shape
    {
        protected double width;
        protected double height;
        public abstract double CalculateSurface();
    }
}
