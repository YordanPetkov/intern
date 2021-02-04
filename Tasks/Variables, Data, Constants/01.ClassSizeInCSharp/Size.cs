using System;

namespace _01.ClassSizeInCSharp
{
    public class Size
    {
        public double width, height;
        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size s, double angleOfRotation)
        {
            double widthAfterRotation = Math.Abs(Math.Cos(angleOfRotation)) * s.width + Math.Abs(Math.Sin(angleOfRotation)) * s.height;
            double heightAfterRotation = Math.Abs(Math.Sin(angleOfRotation)) * s.width + Math.Abs(Math.Cos(angleOfRotation)) * s.height;
            return new Size(widthAfterRotation, heightAfterRotation);
        }
    }
}
