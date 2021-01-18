using System;
using System.Collections.Generic;
using System.Text;

namespace _02.DefineClass
{
    class Path
    {
        private List<Point3D> sequence = new List<Point3D> ();

        public void AddPoint(Point3D a)
        {
            sequence.Add(a);
        }

        public List<Point3D> GetPath()
        {
            return sequence;
        }

        public void RemovePoint(Point3D a)
        {
            sequence.Remove(a);
        }

        public override string ToString()
        {
            string text = "";

            foreach (var point in sequence)
            {
                text += "(" + point.X + "," + point.Y + "," + point.Z + ")" + '\n';
            }

            return text;
        }
    }
}
