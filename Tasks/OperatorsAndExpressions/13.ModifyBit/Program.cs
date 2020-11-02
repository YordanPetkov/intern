using System;

namespace _13.ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            int pos;
            int bitValue;
            long result;

            number = int.Parse(Console.ReadLine());
            pos = int.Parse(Console.ReadLine());
            bitValue = int.Parse(Console.ReadLine());

            if (bitValue == 1) result = number | (1 << pos);
            else result = number & (~(1 << pos));


            Console.WriteLine(result);
        }
    }
}
