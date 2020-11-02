using System;

namespace _06.BiggestOf5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = new double[5];
            double maxNumber = 0;
            for (int i = 0; i < 5; i++)
            {
                number[i] = double.Parse(Console.ReadLine());
                if(maxNumber < number[i])
                {
                    maxNumber = number[i];
                }
            }
            Console.WriteLine(maxNumber);

        }
    }
}
