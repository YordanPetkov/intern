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

        protected virtual double Width 
        {
            get => Width;
            set 
            {
                if (value < 0)
                {
                    Width = 0;
                }
                else
                {
                    Width = value;
                }
            }
        }
        protected virtual double Height
        {
            get => Height;
            set
            {
                if (value < 0)
                {
                    Height = 0;
                }
                else
                {
                    Height = value;
                }
            }
        }
        protected virtual double Radius
        {
            get => Radius;
            set
            {
                if (value < 0)
                {
                    Radius = 0;
                }
                else
                {
                    Radius = value;
                }
            }
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
    }
}
