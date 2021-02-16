using System;

namespace _02.CompareSimpleMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding numbers of type int :");
            Console.WriteLine("{0:F8}", AddingTest.Add(int.MaxValue/2, int.MaxValue/2));

            Console.WriteLine("Adding numbers of type long :");
            Console.WriteLine("{0:F8}", AddingTest.Add(long.MaxValue / 2, long.MaxValue / 2));

            Console.WriteLine("Adding numbers of type float :");
            Console.WriteLine("{0:F8}", AddingTest.Add(float.MaxValue / 2, float.MaxValue / 2));

            Console.WriteLine("Adding numbers of type double :");
            Console.WriteLine("{0:F8}", AddingTest.Add(double.MaxValue / 2, double.MaxValue / 2));

            Console.WriteLine("Adding numbers of type decimal :");
            Console.WriteLine("{0:F8}", AddingTest.Add(decimal.MaxValue / 3, decimal.MaxValue / 3));

            Console.WriteLine("Subtracting numbers of type int :");
            Console.WriteLine("{0:F8}", SubtractionTest.Subtract(int.MaxValue / 2, int.MaxValue / 2));

            Console.WriteLine("Subtracting numbers of type long :");
            Console.WriteLine("{0:F8}", SubtractionTest.Subtract(long.MaxValue / 2, long.MaxValue / 2));

            Console.WriteLine("Subtracting numbers of type float :");
            Console.WriteLine("{0:F8}", SubtractionTest.Subtract(float.MaxValue / 2, float.MaxValue / 2));

            Console.WriteLine("Subtracting numbers of type double :");
            Console.WriteLine("{0:F8}", SubtractionTest.Subtract(double.MaxValue / 2, double.MaxValue / 2));

            Console.WriteLine("Subtracting numbers of type decimal :");
            Console.WriteLine("{0:F8}", SubtractionTest.Subtract(decimal.MaxValue / 3, decimal.MaxValue / 3));

            Console.WriteLine("Incrementing numbers of type int :");
            Console.WriteLine("{0:F8}", IncrementingTest.Increment(int.MaxValue-1));

            Console.WriteLine("Incrementing numbers of type long :");
            Console.WriteLine("{0:F8}", IncrementingTest.Increment(long.MaxValue-1));

            Console.WriteLine("Incrementing numbers of type float :");
            Console.WriteLine("{0:F8}", IncrementingTest.Increment(float.MaxValue-1));

            Console.WriteLine("Incrementing numbers of type double :");
            Console.WriteLine("{0:F8}", IncrementingTest.Increment(double.MaxValue-1));

            Console.WriteLine("Incrementing numbers of type decimal :");
            Console.WriteLine("{0:F8}", IncrementingTest.Increment(decimal.MaxValue-1));
            
            Console.WriteLine("Multipling numbers of type int :");
            Console.WriteLine("{0:F8}", MultiplicationTest.Multiply(Math.Sqrt(int.MaxValue), Math.Sqrt(int.MaxValue)));

            Console.WriteLine("Multipling numbers of type long :");
            Console.WriteLine("{0:F8}", MultiplicationTest.Multiply(Math.Sqrt(long.MaxValue), Math.Sqrt(long.MaxValue)));

            Console.WriteLine("Multipling numbers of type float :");
            Console.WriteLine("{0:F8}", MultiplicationTest.Multiply(Math.Sqrt(float.MaxValue), Math.Sqrt(float.MaxValue)));

            Console.WriteLine("Multipling numbers of type double :");
            Console.WriteLine("{0:F8}", MultiplicationTest.Multiply(Math.Sqrt(double.MaxValue), Math.Sqrt(double.MaxValue)));

            Console.WriteLine("Multipling numbers of type decimal :");
            Console.WriteLine("{0:F8}", MultiplicationTest.Multiply(decimal.MaxValue/1000000, 1000000));

            Console.WriteLine("Dividing numbers of type int :");
            Console.WriteLine("{0:F8}", DivisionTest.Divide(int.MaxValue, int.MaxValue));

            Console.WriteLine("Dividing numbers of type long :");
            Console.WriteLine("{0:F8}", DivisionTest.Divide(long.MaxValue, long.MaxValue));

            Console.WriteLine("Dividing numbers of type float :");
            Console.WriteLine("{0:F8}", DivisionTest.Divide(float.MaxValue, float.MaxValue));

            Console.WriteLine("Dividing numbers of type double :");
            Console.WriteLine("{0:F8}", DivisionTest.Divide(double.MaxValue, double.MaxValue));

            Console.WriteLine("Dividing numbers of type decimal :");
            Console.WriteLine("{0:F8}", DivisionTest.Divide(decimal.MaxValue, decimal.MaxValue));

        }
    }
}
