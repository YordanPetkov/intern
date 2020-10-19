using System;

namespace _06.PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 11; i++)
            {
                if(i % 2 == 0)Console.WriteLine(i);
                else Console.WriteLine(-i);
            }
        }
    }
}
