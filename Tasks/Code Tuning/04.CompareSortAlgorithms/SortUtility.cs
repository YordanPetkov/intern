using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompareSortAlgorithms
{
    public static class SortUtility
    {
        public static void InsertionSort<T>(ref T[] array) where T : IComparable
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }

        public static void SelectionSort<T>(ref T[] array) where T : IComparable
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                T minValue = array[minIndex];
                array[minIndex] = array[i];
                array[i] = minValue;
            }
        }

        public static void QuickSort<T>(ref T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                int middle = Partition(ref array, low, high);
                QuickSort<T>(ref array, low, middle - 1);
                QuickSort<T>(ref array, middle + 1, high);
            }
        }

        private static int Partition<T>(ref T[] array, int low, int high) where T : IComparable
        {
            T pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j].CompareTo(pivot) < 0)
                {
                    i++;
                    T valueAtIndexI = array[i];
                    array[i] = array[j];
                    array[j] = valueAtIndexI;
                }
            }

            T valueAfterIndexI = array[i + 1];
            array[i + 1] = array[high];
            array[high] = valueAfterIndexI;

            return i + 1;
        }
      
        public static void PrintInsertionSortTime<T>(T[] arr, string message = "") where T : IComparable
        {
            var watch = new Stopwatch();

            watch.Start();
            InsertionSort<T>(ref arr);
            watch.Stop();

            Console.WriteLine(message + " " + watch.Elapsed);
        }

        public static void PrintSelectionSortTime<T>(T[] arr, string message = "") where T : IComparable
        {
            var watch = new Stopwatch();

            watch.Start();
            SelectionSort<T>(ref arr);
            watch.Stop();

            Console.WriteLine(message + " " + watch.Elapsed);
        }

        public static void PrintQuickSortTime<T>(T[] arr, string message = "") where T : IComparable
        {
            var watch = new Stopwatch();

            watch.Start();
            QuickSort<T>(ref arr, 0, arr.Length - 1);
            watch.Stop();

            Console.WriteLine(message + " " + watch.Elapsed);
        }
    }
}
