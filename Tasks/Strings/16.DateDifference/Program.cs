using System;
using System.Collections.Generic;
using System.Text;

namespace _16.DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first date: ");
            string firstDateText = Console.ReadLine();
            string[] firstDateParts = firstDateText.Split('.');
            DateTime firstDate = new DateTime(int.Parse(firstDateParts[2]), int.Parse(firstDateParts[1]), int.Parse(firstDateParts[0]));
            Console.Write("Enter the second date: ");
            string secondDateText = Console.ReadLine();
            string[] secondDateParts = secondDateText.Split('.');
            DateTime secondDate = new DateTime(int.Parse(secondDateParts[2]), int.Parse(secondDateParts[1]), int.Parse(secondDateParts[0]));
            TimeSpan difference = secondDate - firstDate;
            if(difference.Days == 1)
            {
                Console.WriteLine("Distance: {0} day", difference.Days);
            }
            else
            {
                Console.WriteLine("Distance: {0} days", difference.Days);
            }
        }
    }
}
