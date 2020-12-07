using System;

namespace _06.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SIZE = 20;
            string text = Console.ReadLine();
            int numberOfStars = MAX_SIZE - text.Length;

            for (int i = 0; i < numberOfStars; i++)
            {
                text += "*";
            }

            if(text.Length > MAX_SIZE)
            {
                text = text.Remove(MAX_SIZE);
            }
            Console.WriteLine(text);
        }
    }
}
