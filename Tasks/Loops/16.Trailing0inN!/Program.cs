using System;

namespace _16.Trailing0inN_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                while(num % 5 == 0 && num != 0)
                {
                    counter++;
                    num /= 5;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
