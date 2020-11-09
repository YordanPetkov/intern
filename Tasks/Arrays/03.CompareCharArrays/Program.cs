using System;

namespace _03.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array1 = input.ToCharArray();
            input = Console.ReadLine();
            char[] array2 = input.ToCharArray();
            char symbol = '=';

            for (int i = 0; i < Math.Min(array1.Length,array2.Length); i++)
            {
                if(array1[i] > array2[i])
                {
                    symbol = '>';
                    break;
                }
                if(array1[i] < array2[i])
                {
                    symbol = '<';
                    break;
                }
            }

            if(symbol == '=' && array1.Length > array2.Length)
            {
                symbol = '>';
            }
            if (symbol == '=' && array1.Length < array2.Length)
            {
                symbol = '<';
            }
            Console.WriteLine(symbol);
        }
    }
}
