using System;
using System.Collections.Generic;
using System.Text;

namespace _02.DefineClass
{
    class Point3D
    {
        private int x;
        private int y;
        private int z;
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public Point3D(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public static Point3D O { get { return o; } }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Z { get { return z; } set { z = value; } }
        public override string ToString()
        {
            return "(" + x + "," + y + "," + z + ")";
        }
    }
}
