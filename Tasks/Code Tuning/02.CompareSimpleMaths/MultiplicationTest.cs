using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CompareSimpleMaths
{
    public static class MultiplicationTest
    {
        public static double Multiply(int firstNumber, int secondNumber)
        {
            DateTime startTime = DateTime.Now;
            int result = firstNumber * secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Multiply(long firstNumber, long secondNumber)
        {
            DateTime startTime = DateTime.Now;
            long result = firstNumber * secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Multiply(float firstNumber, float secondNumber)
        {
            DateTime startTime = DateTime.Now;
            float result = firstNumber * secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            DateTime startTime = DateTime.Now;
            double result = firstNumber * secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }

        public static double Multiply(decimal firstNumber, decimal secondNumber)
        {
            DateTime startTime = DateTime.Now;
            decimal result = firstNumber * secondNumber;
            DateTime endTime = DateTime.Now;
            return (endTime - startTime).TotalSeconds;
        }
    }
}
