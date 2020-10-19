using System;

namespace _12.NthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, pos;
            int bitAtPos;
            number = int.Parse(Console.ReadLine());
            pos = int.Parse(Console.ReadLine());
            bitAtPos = (number >> pos) & 1;
            Console.WriteLine(bitAtPos);
        }
    }
}
