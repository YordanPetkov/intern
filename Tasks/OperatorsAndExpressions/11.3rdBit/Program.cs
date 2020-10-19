using System;

namespace _11._3rdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int bitAt3rdPos;
            number = int.Parse(Console.ReadLine());
            bitAt3rdPos = (number >> 3) & 1;
            Console.WriteLine(bitAt3rdPos);
        }
    }
}
