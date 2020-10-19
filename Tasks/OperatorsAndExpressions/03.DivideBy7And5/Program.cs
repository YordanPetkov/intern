using System;

namespace _03.DivideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = int.Parse(Console.ReadLine());
            Console.Write(number % 5 == 0 && number % 7 == 0);
            Console.WriteLine(" " + number);

        }
    }
}
