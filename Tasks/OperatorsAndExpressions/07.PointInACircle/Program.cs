using System;

namespace _07.PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, distance;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            distance =Math.Sqrt(x * x + y * y);

            if (distance <= 2.0) Console.WriteLine("yes {0}", distance.ToString("0.00"));
            else Console.WriteLine("no {0}", distance.ToString("0.00"));

        }
    }
}
