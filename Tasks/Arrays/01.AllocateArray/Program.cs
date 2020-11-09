using System;

namespace _01.AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = i * 5;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
