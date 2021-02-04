using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Abstraction
{
    class Rectangle : Figure
    {
        public Rectangle()
            : base(0, 0)
        {
        }

        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        protected override double Radius
        {
            get
            {
                throw new NotImplementedException("Rectangle does not have Radius");
            }
            set
            {
                throw new NotImplementedException("Rectangle does not have Radius");
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
