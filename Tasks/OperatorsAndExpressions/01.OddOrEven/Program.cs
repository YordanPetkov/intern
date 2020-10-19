using System;
using System.Runtime.InteropServices;

namespace _01.OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte number;
            number = SByte.Parse(Console.ReadLine());

            if (number % 2 == 0) Console.WriteLine("even {0}", number);
            else Console.WriteLine("odd {0}", number);
        }
    }
}
