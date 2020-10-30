using System;

namespace _04.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double height;
            double area;
            double perimeter;

            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());

            area = width * height;
            perimeter = (width + height) * 2;

            Console.WriteLine(area.ToString("0.00") + " " + perimeter.ToString("0.00"));
        }
    }
}
