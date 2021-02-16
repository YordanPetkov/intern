using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CohesionAndCoupling
{
    struct Point
    {
        public double x;
        public double y; 
        public double z;

        public Point(double x, double y, double z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
