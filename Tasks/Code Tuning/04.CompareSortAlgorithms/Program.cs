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
            GetRandomDoubleArray(ref randomDecimals, count);

            string[] sortedWords = new string[count];
            GetRandomStringArray(ref randomWords, count);

            int[] ReverseSortedNumbers = new int[count];
            GetRandomIntArray(ref randomNumbers, count);

            double[] ReverseSortedDecimals = new double[count];
            GetRandomDoubleArray(ref randomDecimals, count);

            string[] ReverseSortedWords = new string[count];
            GetRandomStringArray(ref randomWords, count);


            InsertionSort<int> insertionSortRandomIntegers = new InsertionSort<int>(randomNumbers);
            insertionSortRandomIntegers.PrintArray();
            DateTime startTime = DateTime.Now;
            insertionSortRandomIntegers.Sort();
            DateTime endTime = DateTime.Now;
            double seconds = (endTime - startTime).TotalSeconds;
            Console.WriteLine(seconds);
            insertionSortRandomIntegers.PrintArray();
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
            for (int i = 0; i < count; i++)
            {
                var rand = new Random();
                arr[i] = rand.NextDouble();
            }
        }

        public static void GetRandomStringArray(ref string[] arr, int count)
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

            for (int i = 0; i < count; i++)
            {
                var rand = new Random();
                int size = rand.Next(0, 100);
                StringBuilder word = new StringBuilder(size);
                for (int j = 0; j < size; j++)
                {
                    rand = new Random();
                    int index = rand.Next(0, chars.Length - 1);
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
            for (int i = 0; i < count; i++)
            {
                arr[i] = (double)i + 0.5;
            }
        }

    }
}
