using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CompareSimpleMaths
{
    public static class IncrementingTest
    {
        public static double Increment(int number)
        {
            DateTime startTime = DateTime.Now;
            number++;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Increment(long number)
        {
            DateTime startTime = DateTime.Now;
            number++;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Increment(float number)
        {
            DateTime startTime = DateTime.Now;
            number++;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Increment(double number)
        {
            DateTime startTime = DateTime.Now;
            number++;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Increment(decimal number)
        {
            DateTime startTime = DateTime.Now;
            number++;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }
    }
}
