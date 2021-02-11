using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CompareSimpleMaths
{
    public static class SubtractionTest
    {
        public static double Subtract(int firstNumber, int secondNumber)
        {
            DateTime startTime = DateTime.Now;
            int result = firstNumber - secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Subtract(long firstNumber, long secondNumber)
        {
            DateTime startTime = DateTime.Now;
            long result = firstNumber - secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Subtract(float firstNumber, float secondNumber)
        {
            DateTime startTime = DateTime.Now;
            float result = firstNumber - secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            DateTime startTime = DateTime.Now;
            double result = firstNumber - secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Subtract(decimal firstNumber, decimal secondNumber)
        {
            DateTime startTime = DateTime.Now;
            decimal result = firstNumber - secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }
    }
}
