using System;

namespace _11.BinarySearch
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

            int x = int.Parse(Console.ReadLine());
            int l = 0;
            int r = n - 1;
            int index = -1;

            while(l <= r)
            {
                int curIndex = (l + r) / 2;
                if (nums[curIndex] < x)
                {
                    l = curIndex + 1;
                }
                else if (nums[curIndex] > x)
                {
                    r = curIndex - 1;
                }
                else
                {
                    index = curIndex;
                    r = curIndex - 1;
                }
            }

            Console.WriteLine(index);
        }
    }
}
