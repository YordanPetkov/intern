using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareAdvancedMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square root");

            var watch = new Stopwatch();
            watch.Start();
            double result = Math.Sqrt((double)float.MaxValue);
            watch.Stop();
            Console.WriteLine("\tFloats : {0}", watch.Elapsed);

            watch = new Stopwatch();
            watch.Start();
            result = Math.Sqrt(double.MaxValue);
            watch.Stop();
            Console.WriteLine("\tDoubles : {0}", watch.Elapsed);

            watch = new Stopwatch();
            watch.Start();
            result = Math.Sqrt((double)decimal.MaxValue);
            watch.Stop();
            Console.WriteLine("\tDecimals : {0}", watch.Elapsed);

            Console.WriteLine("Natural logarithm");

            watch = new Stopwatch();
            watch.Start();
            result = Math.Log((double)float.MaxValue);
            watch.Stop();
            Console.WriteLine("\tFloats : {0}", watch.Elapsed);

            watch = new Stopwatch();
            watch.Start();
            result = Math.Log(double.MaxValue);
            watch.Stop();
            Console.WriteLine("\tDoubles : {0}", watch.Elapsed);

            watch = new Stopwatch();
            watch.Start();
            result = Math.Log((double)decimal.MaxValue);
            watch.Stop();
            Console.WriteLine("\tDecimals : {0}", watch.Elapsed);

            Console.WriteLine("Sinus");

            watch = new Stopwatch();
            watch.Start();
            result = Math.Sin((double)float.MaxValue);
            watch.Stop();
            Console.WriteLine("\tFloats : {0}", watch.Elapsed);

            watch = new Stopwatch();
            watch.Start();
            result = Math.Sin(double.MaxValue);
            watch.Stop();
            Console.WriteLine("\tDoubles : {0}", watch.Elapsed);

            watch = new Stopwatch();
            watch.Start();
            result = Math.Sin((double)decimal.MaxValue);
            watch.Stop();
            Console.WriteLine("\tDecimals : {0}", watch.Elapsed);
        }
    }
}
