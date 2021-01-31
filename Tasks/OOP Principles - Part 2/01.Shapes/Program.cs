using System;

namespace _01.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Rectangle(4,5), new Triangle(2,4), new Square(7)};

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
