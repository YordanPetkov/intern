using System;

namespace _15.GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = input.Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }

            Console.WriteLine(a);
        }
    }
}
