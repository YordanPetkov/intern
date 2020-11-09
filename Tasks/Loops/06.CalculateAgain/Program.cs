using System;

namespace _06.CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            long nFact = 1;
            long kFact = 1;
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

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
