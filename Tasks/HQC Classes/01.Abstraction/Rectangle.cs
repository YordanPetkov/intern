using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Abstraction
{
    class Rectangle : Figure
    {
        private double _width;
        private double _height;

        public Rectangle(double width = 0, double height = 0)
        {
            Width = width;
            Height = height;
        }

        public virtual double Width
        {
            get => _width;
            set
            {
                if (value < 0)
                {
                    _width = 0;
                }
                else
                {
                    _width = value;
                }
            }
        }

        public virtual double Height
        {
            get => _height;
            set
            {
                if (value < 0)
                {
                    _height = 0;
                }
                else
                {
                    _height = value;
                }
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
