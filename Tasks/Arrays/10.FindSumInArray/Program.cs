using System;

namespace _10.FindSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitted = input.Split(", ");
            int[] nums = new int[splitted.Length];

            for (int i = 0; i < splitted.Length; i++)
            {
                nums[i] = int.Parse(splitted[i]);
            }

            int s = int.Parse(Console.ReadLine());
            int seqFirstIndex = 0;
            int seqLastIndex = 0;
            int curSum = 0;
            bool seqPresent = false;

            for (int i = 0; i < splitted.Length; i++)
            {
                if(curSum + nums[i] <= s)
                {
                    curSum += nums[i];
                    seqLastIndex = i;
                    if(curSum == s)
                    {
                        seqPresent = true;
                        break;
                    }
                }
                else if(curSum + nums[i] > s)
                {
                    curSum = nums[i];
                    seqFirstIndex = i;
                    seqLastIndex = i;
                }
            }

            
            if(seqPresent)
            {
                for (int i = seqFirstIndex; i < seqLastIndex; i++)
                {
                    Console.Write("{0}, ", nums[i]);
                }
                Console.WriteLine(nums[seqLastIndex]);
            }
            else
            {
                Console.WriteLine("There is no sequence of given sum {0}." , s);
            }
        }
    }
}
