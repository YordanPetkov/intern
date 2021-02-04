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
            PrintAvg(sumNumbers / countNumbers);
        }

    }
}
