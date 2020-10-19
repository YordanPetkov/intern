using System;

namespace _09.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());

            double area;
            area = ((a + b) * h / 2.0);
            Console.WriteLine(area.ToString("0.0000000"));
        }
    }
}
