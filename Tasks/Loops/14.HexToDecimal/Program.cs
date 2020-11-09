using System;

namespace _14.HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();
            long decimalNum = 0;

            for (int i = hexNum.Length - 1; i >= 0; i--)
            {
                switch(hexNum[i])
                {
                    case 'A':
                        decimalNum += (long)(Math.Pow(16, hexNum.Length - 1 - i)) * 10;
                        break;
                    case 'B':
                        decimalNum += (long)(Math.Pow(16, hexNum.Length - 1 - i)) * 11;
                        break;
                    case 'C':
                        decimalNum += (long)(Math.Pow(16, hexNum.Length - 1 - i)) * 12;
                        break;
                    case 'D':
                        decimalNum += (long)(Math.Pow(16, hexNum.Length - 1 - i)) * 13;
                        break;
                    case 'E':
                        decimalNum += (long)(Math.Pow(16, hexNum.Length - 1 - i)) * 14;
                        break;
                    case 'F':
                        decimalNum += (long)(Math.Pow(16, hexNum.Length - 1 - i)) * 15;
                        break;
                    default:
                        decimalNum += (long)(Math.Pow(16, hexNum.Length - 1 - i)) * (hexNum[i] - '0');
                        break;
                }
            }

            Console.WriteLine(decimalNum);
        }
    }
}
