using System;

namespace _02.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            ReadNumber(start, end);
        }

        static void ReadNumber(int start, int end)
        {
            bool validInput = true;
            int[] numbers = new int[11];
            numbers[0] = start;

            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    if (numbers[i] > end || numbers[i-1] > numbers[i])
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    validInput = false;
                }
            }
            
            if(validInput)
            {
                Console.Write(numbers[0]);

                for (int i = 1; i < 11; i++)
                {
                    Console.Write(" < {0}", numbers[i]);
                }

                Console.WriteLine(" < {0}", end);
            }
            else
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
