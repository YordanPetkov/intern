using System;

namespace _16.RemoveElementsFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int[] subSeq = new int[n];
            int maxLength = 0;

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if(i == 0)
                {
                    subSeq[i] = 1;
                }
                else
                {
                    int curLength = 0;

                    for (int j = 0; j < i; j++)
                    {
                        if(nums[j] <= nums[i] && curLength < subSeq[j])
                        {
                            curLength = subSeq[j];
                        }
                        subSeq[i] = curLength + 1;
                        if(subSeq[i] > maxLength)
                        {
                            maxLength = subSeq[i];
                        }
                    }

                }
            }

            Console.WriteLine(n - maxLength);
        }
    }
}
