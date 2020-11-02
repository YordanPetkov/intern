using System;

namespace _11.Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            int counter = 0;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            for (int i = n + 1; i < m; i++)
            {
                if (i % 5 == 0) counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
