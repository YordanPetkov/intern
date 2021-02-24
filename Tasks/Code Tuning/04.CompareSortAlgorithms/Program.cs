using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompareSortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;

            int[] randomNumbers = new int[count];
            GetRandomIntArray(ref randomNumbers, count);

            double[] randomDecimals = new double[count];
            GetRandomDoubleArray(ref randomDecimals, count);

            string[] randomWords = new string[count];
            GetRandomStringArray(ref randomWords, count);

            int[] sortedNumbers = new int[count];
            GetSortedIntArray(ref sortedNumbers, count);

            double[] sortedDecimals = new double[count];
            GetSortedDoubleArray(ref randomDecimals, count);

            string[] sortedWords = new string[count];
            GetRandomStringArray(ref randomWords, count);

            int[] ReverseSortedNumbers = new int[count];
            GetRandomIntArray(ref randomNumbers, count);

            double[] ReverseSortedDecimals = new double[count];
            GetRandomDoubleArray(ref randomDecimals, count);

            string[] ReverseSortedWords = new string[count];
            GetRandomStringArray(ref randomWords, count);

            PrintInsertionSortTime(randomNumbers);
            PrintInsertionSortTime(randomDecimals);
            PrintInsertionSortTime(randomWords);
            PrintInsertionSortTime(sortedNumbers);
            PrintInsertionSortTime(sortedDecimals);
        }

        public static void PrintInsertionSortTime<T>(T[] arr) where T : IComparable
        {
            InsertionSort<T> insertionSort = new InsertionSort<T>(arr);
            insertionSort.PrintArray();
            DateTime startTime = DateTime.Now;
            insertionSort.Sort();
            DateTime endTime = DateTime.Now;
            double seconds = (endTime - startTime).TotalSeconds;
            Console.WriteLine(seconds);
            insertionSort.PrintArray();
        }

        public static void GetRandomIntArray(ref int[] arr, int count)
        {
            var rand = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
        }

        public static void GetRandomDoubleArray(ref double[] arr, int count)
        {
            var rand = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = rand.NextDouble();
            }
        }

        public static void GetRandomStringArray(ref string[] arr, int count)
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            var randSize = new Random();
            var randSymbol = new Random();
            for (int i = 0; i < count; i++)
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
        }

        public static void GetSortedIntArray(ref int[] arr, int count)
        {
            for (int i = 0; i < count; i++)
            {
                arr[i] = i;
            }
        }

        public static void GetSortedDoubleArray(ref double[] arr, int count)
        {
            double j = 0.15;
            for (int i = 0; i < count; i++)
            {
                j += 0.6;
                arr[i] = j;
            }
        }
    }
}
