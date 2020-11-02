using System;

namespace _01.NumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double minNum = 10000;
            double maxNum = 0;
            double sum = 0;
            double average;

            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double number;
                number = double.Parse(Console.ReadLine());
                sum = sum + number;
                if(minNum > number)
                {
                    minNum = number;
                }
                if(maxNum < number)
                {
                    maxNum = number;
                }
            }
            average = sum / n;

            Console.WriteLine("min={0:0.00}", minNum);
            Console.WriteLine("max={0:0.00}", maxNum);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}", average);
        }
    }
}
