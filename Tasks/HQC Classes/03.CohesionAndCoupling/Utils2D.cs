using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CohesionAndCoupling
{
    static class Utils2D
    {
        public static double CalcDistance2D(Point firstPoint, Point secondPoint)
        {
            double distance = Math.Sqrt((secondPoint.x - firstPoint.x) * (secondPoint.x - firstPoint.x) 
                    + (secondPoint.y - firstPoint.y) * (secondPoint.y - firstPoint.y));
            return distance;
        }
    }
}
