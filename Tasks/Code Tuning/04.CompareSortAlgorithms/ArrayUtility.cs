using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompareSortAlgorithms
{
    public static class ArrayUtility
    {
        public static int[] GetRandomIntArray(int numbersCount)
        {
            int[] arr = new int[numbersCount];
            var rand = new Random();

            for (int i = 0; i < numbersCount; i++)
            {
                arr[i] = rand.Next(0, 100);
            }

            return arr;
        }

        public static double[] GetRandomDoubleArray(int numbersCount)
        {
            double[] arr = new double[numbersCount];
            var rand = new Random();

            for (int i = 0; i < numbersCount; i++)
            {
                arr[i] = rand.NextDouble();
            }

            return arr;
        }

        public static string[] GetRandomStringArray(int numbersCount)
        {
            string[] arr = new string[numbersCount];
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            var randSize = new Random();
            var randSymbol = new Random();
            for (int i = 0; i < numbersCount; i++)
            {
                int size = randSize.Next(0, 100);
                StringBuilder word = new StringBuilder(size);
                for (int j = 0; j < size; j++)
                {
                    int index = randSymbol.Next(0, chars.Length - 1);
                    word.Append(chars[index]);
                }

                arr[i] = word.ToString();
            }

            return arr;
        }

        public static int[] GetSortedIntArray(int numbersCount, bool isAscending)
        {
            int[] arr = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                if (isAscending)
                {
                    arr[i] = i;
                }
                else
                {
                    arr[i] = numbersCount - 1 - i;
                }
            }

            return arr;
        }

        public static double[] GetSortedDoubleArray(int numbersCount, bool isAscending)
        {
            double[] arr = new double[numbersCount];
            double j = 0.15;

            for (int i = 0; i < numbersCount; i++)
            {
                j += 0.6;
                if (isAscending)
                {
                    arr[i] = j;
                }
                else
                {
                    arr[numbersCount - 1 - i] = j;
                }
            }

            return arr;
        }

        public static string[] GetSortedStringArray(int numbersCount, bool isAscending)
        {
            string[] arr = new string[numbersCount];
            int j = 0;
            int i;

            for (i = 0; i < numbersCount; i++)
            {
                arr[i] = "";
            }

            while (j < numbersCount)
            {
                for (i = 0; i < 26 && i < numbersCount; i++)
                {
                    if (isAscending)
                    {
                        arr[i] += (char)(i + 'a');
                    }

                    else
                    {
                        arr[numbersCount - 1 - i] += (char)(i + 'a');
                    }
                }

                j += i;
            }

            return arr;
        }
    }
}
