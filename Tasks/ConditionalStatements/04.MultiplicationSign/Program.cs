using System;

namespace _04.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            int countNegative = 0;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if(a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if(a < 0)
                {
                    countNegative++;
                }
                if(b < 0)
                {
                    countNegative++;
                }
                if(c < 0)
                {
                    countNegative++;
                }
                if(countNegative % 2 == 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}
