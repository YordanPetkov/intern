using System;

namespace _01.ExchangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double helpVar;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            if(a > b)
            {
                helpVar = a;
                a = b;
                b = helpVar;
            }
            
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
