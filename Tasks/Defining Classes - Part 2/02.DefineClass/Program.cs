using System;

namespace _02.DefineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D a = new Point3D(0, 1, 2);
            Point3D o = Point3D.O;
            Console.WriteLine(Distance.PointsIn3D(a, o));
            Path path = PathStorage.LoadPath("../../../path1.txt");
            Console.WriteLine(path.ToString());
            path.AddPoint(a);
            path.AddPoint(o);
            PathStorage.SavePath(path, "../../../path2.txt");
        }
    }
}
