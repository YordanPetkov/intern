using System;

namespace _09.SumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double sum = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double k;
                k = double.Parse(Console.ReadLine());
                sum = sum + k;
            }

            Console.WriteLine(sum);
        }
    }
}
