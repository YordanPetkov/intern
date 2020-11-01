using System;

namespace _01.SumOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double sum;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
