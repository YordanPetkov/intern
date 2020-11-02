using System;

namespace _10.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int first;
            int second;
            n = int.Parse(Console.ReadLine());
            first = 0;
            second = 1;
            if(n <= 0)
            {
                Console.WriteLine("Invalid input.");
            }
            if(n > 0)
            {
                Console.Write("{0}", first);
            }
            if(n > 1)
            {
                Console.Write(", {0}", second);
            }
            if(n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    int iFib;
                    iFib = first + second;
                    Console.Write(", {0}", iFib);
                    first = second;
                    second = iFib;
                }
            }
            Console.WriteLine();
        }
    }
}
