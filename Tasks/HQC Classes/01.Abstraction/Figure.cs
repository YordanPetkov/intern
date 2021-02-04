using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Abstraction
{
    abstract class Figure
    {

        public Figure()
        {
        }

        public Figure(double radius)
        {
            this.Radius = radius;
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual double Radius { get; set; }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
    }
}
