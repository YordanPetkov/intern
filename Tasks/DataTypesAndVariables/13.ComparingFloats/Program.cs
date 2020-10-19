using System;

namespace _13.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            double eps = 0.000001;

            firstNumber = double.Parse(Console.ReadLine());
            secondNumber = double.Parse(Console.ReadLine());

            if (firstNumber - secondNumber <= eps) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
    }
}
