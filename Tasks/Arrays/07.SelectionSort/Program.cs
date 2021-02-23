using System;

namespace _07.SelectionSort
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

            for (int i = 0; i < n; i++)
            {
                int minNum = nums[i];
                int minIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if(minNum > nums[j])
                    {
                        minNum = nums[j];
                        minIndex = j;
                    }
                }

                int helpVar;
                helpVar = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = helpVar;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
