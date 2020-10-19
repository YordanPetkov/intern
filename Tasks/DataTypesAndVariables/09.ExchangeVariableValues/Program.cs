using System;

namespace _09.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0} , b = {1}", a, b);
            a ^= b;
            b ^= a;
            a ^= b;

            Console.WriteLine("a = {0} , b = {1}", a, b);
        }
    }
}
