using System;

namespace _06.CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong combinations = 1;
            ulong n = ulong.Parse(Console.ReadLine());
            ulong k = ulong.Parse(Console.ReadLine());

            for (ulong i = k+1, j = 1; i <= n || j <= n - k ; i++ , j++)
            {
                combinations = combinations * i / j;
            }

            Console.WriteLine(combinations);
        }
    }
}
