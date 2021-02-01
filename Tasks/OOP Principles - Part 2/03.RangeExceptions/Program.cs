using System;

namespace _03.RangeExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            InvalidRangeException<int> rangeOfNumbers = new InvalidRangeException<int>(1, 100);
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);
            InvalidRangeException<DateTime> rangeOfDates = new InvalidRangeException<DateTime>(startDate, endDate);
            Console.WriteLine(rangeOfNumbers.CheckRange(12));
            Console.WriteLine(rangeOfNumbers.CheckRange(190));
            Console.WriteLine(rangeOfDates.CheckRange(new DateTime(2003, 03, 09)));
            Console.WriteLine(rangeOfDates.CheckRange(new DateTime(2021, 02, 01)));
        }
    }
}
