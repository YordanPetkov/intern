using System;

namespace _13.ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, pos, bitValue;
            int result;

            number = int.Parse(Console.ReadLine());
            pos = int.Parse(Console.ReadLine());
            bitValue = int.Parse(Console.ReadLine());

            if (bitValue == 1) result = number | (bitValue << pos);
            else result = number & ~(bitValue << pos);

            Console.WriteLine(result);
        }
    }
}
