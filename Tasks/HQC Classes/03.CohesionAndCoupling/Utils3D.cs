using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CohesionAndCoupling
{
    static class Utils3D
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        public static double CalcDistance3D(Point firstPoint, Point secondPoint)
        {
            double distance = Math.Sqrt((secondPoint.x - firstPoint.x) * (secondPoint.x - firstPoint.x) 
                    + (secondPoint.y - firstPoint.y) * (secondPoint.y - firstPoint.y) 
                    + (secondPoint.z - firstPoint.z) * (secondPoint.z - firstPoint.z));
            return distance;
        }

        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public static double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(new Point(0,0,0), new Point(Width, Height, Depth));
            return distance;
        }

        public static double CalcDiagonalXY()
        {
            double distance = Utils2D.CalcDistance2D(new Point(0,0), new Point(Width, Height));
            return distance;
        }

        public static double CalcDiagonalXZ()
        {
            double distance = Utils2D.CalcDistance2D(new Point(0, 0), new Point(Width, Depth));
            return distance;
        }

        public static double CalcDiagonalYZ()
        {
            double distance = Utils2D.CalcDistance2D(new Point(0, 0), new Point(Height, Depth));
            return distance;
        }
    }
}
