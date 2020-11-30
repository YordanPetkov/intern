using System;

namespace _01_SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0) throw new Exception();
                Console.WriteLine(string.Format("{0:F3}", Math.Sqrt(n)));
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
