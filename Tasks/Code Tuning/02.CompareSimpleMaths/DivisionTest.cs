using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CompareSimpleMaths
{
    public static class DivisionTest
    {
        public static double Divide(int firstNumber, int secondNumber)
        {
            DateTime startTime = DateTime.Now;
            int result = firstNumber / secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Divide(long firstNumber, long secondNumber)
        {
            DateTime startTime = DateTime.Now;
            long result = firstNumber / secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Divide(float firstNumber, float secondNumber)
        {
            DateTime startTime = DateTime.Now;
            float result = firstNumber / secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            DateTime startTime = DateTime.Now;
            double result = firstNumber / secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Divide(decimal firstNumber, decimal secondNumber)
        {
            DateTime startTime = DateTime.Now;
            decimal result = firstNumber / secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }
    }
}
