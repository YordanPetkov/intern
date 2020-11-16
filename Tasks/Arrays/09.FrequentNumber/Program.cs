using System;

namespace _09.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int[] repeatedTimes = new int[10001];
            int mostFrequentNum = int.MinValue;
            int mostRepeatedTimes = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                repeatedTimes[nums[i]]++;
                if(mostRepeatedTimes < repeatedTimes[nums[i]])
                {
                    mostFrequentNum = nums[i];
                    mostRepeatedTimes = repeatedTimes[nums[i]];
                }
            }

            Console.WriteLine("{0} ({1} times)", mostFrequentNum, mostRepeatedTimes);
        }
    }
}
