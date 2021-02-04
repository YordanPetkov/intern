using System;

namespace _03.RefactorTheLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] array = new int[100];
            int expectedValue = 60;
            for (i = 0; i < 100; i++)
            {
                array[i] = i;
            }

            for (i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}
