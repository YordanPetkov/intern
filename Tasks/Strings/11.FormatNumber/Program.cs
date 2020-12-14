using System;

namespace _11.FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number.ToString().PadLeft(15));
            Console.WriteLine(number.ToString("X").PadLeft(15));
            Console.WriteLine(number.ToString("P").PadLeft(15));
            Console.WriteLine(string.Format("{0:#.##E+0}", number).PadLeft(15));
        }
    }
}
