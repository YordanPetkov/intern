using System;

namespace _06.CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k;
            long nFact = 1;
            long kFact = 1;

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                nFact = nFact * i;
                if(i == k)
                {
                    kFact = nFact;
                }
            }

            Console.WriteLine(nFact / kFact);
        }
    }
}
