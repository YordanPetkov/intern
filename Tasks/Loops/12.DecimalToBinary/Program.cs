using Microsoft.VisualBasic.CompilerServices;
using System;

namespace _12.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long decimalNum = long.Parse(Console.ReadLine());
            string binaryNum = "";

            do
            {
                binaryNum = (decimalNum % 2) + binaryNum;
                decimalNum /= 2;
            } while (decimalNum != 0);

            Console.WriteLine(binaryNum);
        }
    }
}
