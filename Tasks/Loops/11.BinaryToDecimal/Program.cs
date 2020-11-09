using System;

namespace _11.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryNum = Console.ReadLine();
            long decimalNum = 0;

            for (int i = binaryNum.Length - 1; i >= 0; i--)
            {
                if(binaryNum[i] == '1')
                {
                    decimalNum += (long)Math.Pow(2, binaryNum.Length - 1 - i);
                }
            }

            Console.WriteLine(decimalNum);
        }
    }
}
