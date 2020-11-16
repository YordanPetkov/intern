using System;

namespace _13.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            sort(nums, 0, n - 1);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        static void sort(int[] array, int left, int right)
        {
            if(left < right)
            {
                int middle = (left + right) / 2;
                sort(array, left, middle);
                sort(array, middle + 1, right);
                merge(array, left, middle, right);
            }
        }

        static void merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            int leftSize = middleIndex - leftIndex + 1;
            int rightSize = rightIndex - middleIndex;
            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];
            int i = 0;

            for (i = 0; i < leftSize; i++)
            {
                leftArray[i] = array[leftIndex + i];
            }

            for (i = 0; i < rightSize; i++)
            {
                rightArray[i] = array[middleIndex + 1 + i];
            }

            i = 0;
            int j = 0;
            int k = leftIndex;

            while(i < leftSize && j < rightSize)
            {
                if(leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while(i < leftSize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while(j < rightSize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
