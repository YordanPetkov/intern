using System;

namespace _06.FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int abcd, a, b, c, d;
            abcd = int.Parse(Console.ReadLine());
            a = abcd / 1000;
            b = abcd % 1000 / 100;
            c = abcd % 100 / 10;
            d = abcd % 10;

            int sum, dcba, dabc, acbd;
            sum = a + b + c + d;
            dcba = d * 1000 + c * 100 + b * 10 + a;
            dabc = d * 1000 + a * 100 + b * 10 + c;
            acbd = a * 1000 + c * 100 + b * 10 + d;

            Console.WriteLine(sum);
            Console.WriteLine(dcba);
            Console.WriteLine(dabc);
            Console.WriteLine(acbd);

        }
    }
}
