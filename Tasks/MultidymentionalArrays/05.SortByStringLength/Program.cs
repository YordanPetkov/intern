using System;

namespace _05.SortByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];

            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }

            quickSort(strings, 0, n - 1);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strings[i]);
            }

        }

        static int partition(string[] array, int low, int high)
        {
            int pivot = array[high].Length;
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j].Length < pivot)
                {
                    i++;
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

            }

            string temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        static void quickSort(string[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = partition(array, low, high);
                quickSort(array, low, middle - 1);
                quickSort(array, middle + 1, high);
            }
        }
    }
}
