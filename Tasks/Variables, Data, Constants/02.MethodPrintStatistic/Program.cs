using System;

namespace _02.MethodPrintStatistic
{
    class Program
    {
        public void PrintStatistics(double[] numbers, int countNumbers)
        {
            double maxNumber = double.MinValue;
            double minNumber = double.MaxValue;
            double sumNumbers = 0;

            for (int i = 0; i < countNumbers; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }

                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }

                sumNumbers += numbers[i];
            }

            PrintMax(maxNumber);
            PrintMin(minNumber);
            PrintAverage(sumNumbers / countNumbers);
        }

        public void PrintMax(double number)
        {
            Console.WriteLine("Biggest number is {0}.", number);
        }

        public void PrintMin(double number)
        {
            Console.WriteLine("Lowest number is {0}.", number);
        }

        public void PrintAverage(double number)
        {
            Console.WriteLine("Average value is {0}.", number);
        }

    }
}
