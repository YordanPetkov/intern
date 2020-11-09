using System;

namespace _02.CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            bool equal = true;

            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if(array1[i] != array2[i])
                {
                    equal = false;
                    break;
                }
            }

            Console.WriteLine(equal ? "Equal" : "Not equal");
        }
    }
}
