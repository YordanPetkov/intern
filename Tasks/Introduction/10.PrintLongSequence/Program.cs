﻿using System;

namespace _10.PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
                else Console.WriteLine(-i);
            }
        }
    }
}
