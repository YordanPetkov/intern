using System;

namespace _14.PrintTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 33; i <= 126; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
        }
    }
}
