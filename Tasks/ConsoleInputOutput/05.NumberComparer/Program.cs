using System;

namespace _05.NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(a,b));
        }
    }
}
