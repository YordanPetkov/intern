using System;

namespace _03.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int k = int.Parse(Console.ReadLine());
            quickSort(nums, 0, n - 1);
            int index = Array.BinarySearch(nums, k);
            if(index > 0)
            {
                Console.WriteLine(nums[index]);
            }
            else
            {
                Console.WriteLine(nums[Math.Abs(index) - 2]);
            }
            
        }

        static int partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        static void quickSort(int[] array, int low, int high)
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
