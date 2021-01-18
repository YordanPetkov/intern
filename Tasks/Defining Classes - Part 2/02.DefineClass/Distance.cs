using System;
using System.Collections.Generic;
using System.Text;

namespace _02.DefineClass
{
    static class Distance
    {
        public static double PointsIn3D(Point3D a, Point3D b)
        {
            return Math.Sqrt(Math.Pow((double)Math.Abs(a.X - b.X), 2) + Math.Pow((double)Math.Abs(a.Y - b.Y), 2) + Math.Pow((double)Math.Abs(a.Z - b.Z), 2));
        }
    }
}
