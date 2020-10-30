using System;

namespace _08.PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (number < 2) isPrime = false;

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if( number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime.ToString().ToLower());
        }
    }
}
