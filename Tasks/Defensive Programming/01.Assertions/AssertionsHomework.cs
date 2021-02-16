using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Assertions
{
    class AssertionsHomework
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Array is empty!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] array, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(array.Length > 0, "Array is empty!");
            Debug.Assert((startIndex >= 0 && startIndex < array.Length), "Index was out of range. Must be non-negative and less than the size of the collection!");
            Debug.Assert((endIndex >= 0 && endIndex < array.Length), "Index was out of range. Must be non-negative and less than the size of the collection!");
            
            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i].CompareTo(array[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        public static int BinarySearch<T>(T[] array, T value) where T : IComparable<T>
        {
            Debug.Assert(array.Length > 0, "Array is empty!");

            return BinarySearch(array, value, 0, array.Length - 1);
        }

        private static int BinarySearch<T>(T[] array, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(array.Length > 0, "Array is empty!");
            Debug.Assert((startIndex >= 0 && startIndex < array.Length), "Index was out of range. Must be non-negative and less than the size of the collection!");
            Debug.Assert((endIndex >= 0 && endIndex < array.Length), "Index was out of range. Must be non-negative and less than the size of the collection!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (array[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (array[midIndex].CompareTo(value) < 0)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    endIndex = midIndex - 1;
                }
            }

            return -1;
        }

        static void Main()
        {
            int[] numbers = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", numbers));
            SelectionSort(numbers);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", numbers));

            SelectionSort(new int[0]);
            SelectionSort(new int[1]);

            Console.WriteLine(BinarySearch(numbers, -1000));
            Console.WriteLine(BinarySearch(numbers, 0));
            Console.WriteLine(BinarySearch(numbers, 17));
            Console.WriteLine(BinarySearch(numbers, 10));
            Console.WriteLine(BinarySearch(numbers, 1000));
        }
    }
}
