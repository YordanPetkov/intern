using System;

namespace _06.QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double x1;
            double x2;
            double discr;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            discr = b * b - 4 * a * c;
            if(discr < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if(discr == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("{0:0.00}", x1);
            }
            else
            {

                x1 = (Math.Sqrt(discr) - b) / (2 * a);
                x2 = (-Math.Sqrt(discr) - b) / (2 * a);
                Console.WriteLine("{0:0.00}", Math.Min(x1, x2));
                Console.WriteLine("{0:0.00}", Math.Max(x1, x2));
            }

        }
    }
}
