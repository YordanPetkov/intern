using System;

namespace _05.BiggestOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double maxNum = 0;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if(a > maxNum)
            {
                maxNum = a;
            }
            if(b > maxNum)
            {
                maxNum = b;
            }
            if(c > maxNum)
            {
                maxNum = c;
            }
            Console.WriteLine(maxNum);
        }
    }
}
