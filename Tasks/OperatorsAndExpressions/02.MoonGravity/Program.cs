using System;

namespace _02.MoonGravity
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightOnEarth;
            double weightOnMoon;
            weightOnEarth = Double.Parse(Console.ReadLine());
            weightOnMoon = 17.0 / 100.0 * weightOnEarth;
            Console.WriteLine(weightOnMoon.ToString("0.000"));
        }
    }
}
