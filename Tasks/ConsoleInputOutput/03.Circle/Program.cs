using System;

namespace _03.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double perimeter;
            double area;
            r = double.Parse(Console.ReadLine());

            perimeter = 2 * Math.PI * r;
            area = Math.PI * r * r;

            Console.WriteLine("{0:0.00}", perimeter);
            Console.WriteLine("{0:0.00}", area);

        }
    }
}
