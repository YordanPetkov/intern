using System;

namespace _05.ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number;
            //int thirdDigit;
            //number = int.Parse(Console.ReadLine());

            //thirdDigit = number % 1000 / 100;

            //if (thirdDigit == 7) Console.WriteLine(true);
            //else Console.WriteLine("{0} {1}", false ,thirdDigit);

            string number;
            number = Console.Readline();

            if (number[number.lenght - 2] == '7')
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("{0} {1}", false, number[number.lenght - 2]);
            }
        }
    }
}
