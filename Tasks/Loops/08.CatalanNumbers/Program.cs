using System;

namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double catalanNumber = 1;
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 2; i <= n; i++)
            {
                catalanNumber *= (double)(n + i) / (double)(i);
            }
            
            Console.WriteLine(Math.Ceiling(catalanNumber));
        }
    }
}
