using System;

namespace _13.DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            long decimalNum = long.Parse(Console.ReadLine());
            string hexNum = "";

            do
            {
                switch(decimalNum % 16)
                {
                    case 10:
                        hexNum = 'A' + hexNum;
                        break;
                    case 11:
                        hexNum = 'B' + hexNum;
                        break;
                    case 12:
                        hexNum = 'C' + hexNum;
                        break;
                    case 13:
                        hexNum = 'D' + hexNum;
                        break;
                    case 14:
                        hexNum = 'E' + hexNum;
                        break;
                    case 15:
                        hexNum = 'F' + hexNum;
                        break;
                    default:
                        hexNum = decimalNum % 16 + hexNum;
                        break;
                }
                decimalNum /= 16;
            } while (decimalNum != 0);

            Console.WriteLine(hexNum);
        }
    }
}
