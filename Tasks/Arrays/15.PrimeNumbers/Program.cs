using System;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] compositeNums = new bool[n+1];

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if(compositeNums[i] == false)
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        compositeNums[j] = true;
                    }
                }
            }

            for (int i = n; i >= 2; i--)
            {
                if(compositeNums[i] == false)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
