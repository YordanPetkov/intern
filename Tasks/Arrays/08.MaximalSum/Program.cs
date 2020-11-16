using System;

namespace _08.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int maxSum = int.MinValue;
            int lastSum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if(lastSum < 0)
                {
                    lastSum = nums[i];
                }
                else
                {
                    lastSum += nums[i];
                }
                if(maxSum < lastSum)
                {
                    maxSum = lastSum;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
