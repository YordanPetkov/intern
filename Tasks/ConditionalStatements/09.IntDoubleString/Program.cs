using System;

namespace _09.IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            int integer;
            double realNumber;
            string word;
            type = Console.ReadLine();

            switch(type)
            {
                case "integer":
                    integer = int.Parse(Console.ReadLine());
                    Console.WriteLine(integer + 1);
                    break;
                case "real":
                    realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}",realNumber + 1.0);
                    break;
                case "text":
                    word = Console.ReadLine();
                    Console.WriteLine(word + "*");
                    break;
                default:
                    Console.WriteLine("Incorrect type!");
                    break;
            }
        }
    }
}
