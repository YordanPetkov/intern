using System;

namespace _07.SumOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (int number in numbers)
            {
                sum = sum + number;
            }

            Console.WriteLine(sum);
        }
    }
}
