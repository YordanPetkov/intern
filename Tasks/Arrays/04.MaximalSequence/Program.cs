using System;

namespace _04.MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int maxSequence = 0;
            int counter = 1;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                if(array[i] == array[i - 1])
                {
                    counter++;
                }
                else
                {
                    if(counter > maxSequence)
                    {
                        maxSequence = counter;
                    }
                    counter = 1;
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}
