using System;

namespace _06.CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n;
            ulong k;
            ulong combinations = 1;

            n = ulong.Parse(Console.ReadLine());
            k = ulong.Parse(Console.ReadLine());


            for (ulong i = k+1, j = 1; i <= n || j <= n - k ; i++ , j++)
            {
                combinations = combinations * i / j;
            }

            Console.WriteLine(combinations);
        }
    }
}
