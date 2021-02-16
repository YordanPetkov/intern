using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Abstraction
{
    class Circle : Figure
    {
        private double _radius;

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public virtual double Radius
        {
            get => _radius;
            set
            {
                if (value < 0)
                {
                    _radius = 0;
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
