using System;

namespace _03.RefactorTheLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValueFound = false;
            int[] array = new int[100];

            for (int i = 0; i < 100; i++)
            {
                array[i] = i;
            }

            int expectedValue = 60;
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        isValueFound = true;
                        break;
                    }
                }

                else
                {
                    Console.WriteLine(array[i]);
                }
            }

            if (isValueFound)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}
