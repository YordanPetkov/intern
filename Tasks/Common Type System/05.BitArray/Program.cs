using System;

namespace _05.BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 bitArray = new BitArray64();
            bitArray[4] = 1;
            bitArray[7] = 1;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + " " + bitArray[i]);
            }
        }
    }
}
