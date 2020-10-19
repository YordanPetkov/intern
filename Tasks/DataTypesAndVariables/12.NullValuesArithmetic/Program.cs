using System;

namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullInteger = null;
            double? nullDecimal = null;

            Console.WriteLine(nullInteger);
            Console.WriteLine(nullDecimal);

            Console.WriteLine(nullInteger + 5);
            Console.WriteLine(nullDecimal + 3.12);

        }
    }
}
