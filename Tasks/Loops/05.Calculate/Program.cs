using System;

namespace _05.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            long lastFact = 1;
            long curFact;
            double s = 1;
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                curFact = lastFact * i;
                lastFact = curFact;
                s = s +  (double)(curFact) / (double)(Math.Pow(x, i));
            }

            Console.WriteLine("{0:0.00000}", s);
        }
    }
}
