using System;

namespace _02.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = Console.ReadLine();
            string reversedText = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }

            Console.WriteLine(reversedText);
        }
    }
}
