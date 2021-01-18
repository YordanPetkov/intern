using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _02.DefineClass
{
    static class PathStorage
    {
        public static void SavePath(Path path, string file)
        {
            List<Point3D> sequence = path.GetPath();
            try
            {
                using (var writer = new StreamWriter(file))
                {
                    foreach (Point3D point in sequence)
                    {
                        writer.WriteLine(point.ToString());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }
        }

        public static Path LoadPath(string file)
        {
            Path path = new Path();
            try
            {
                using (var reader = new StreamReader(file))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        string[] coordinates = line.Split(',', '(', ')');
                        Point3D point = new Point3D(int.Parse(coordinates[1]), int.Parse(coordinates[2]), int.Parse(coordinates[3]));
                        path.AddPoint(point);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }

            return path;
        }
    }
}
