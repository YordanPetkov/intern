using System;

namespace _23.SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string newText = "";

            for (int i = 1; i < text.Length; i++)
            {
                if(text[i] != text[i-1])
                {
                    newText += text[i-1];
                }
                if(i == text.Length - 1)
                {
                    newText += text[i];
                }
            }

            Console.WriteLine(newText);
        }
    }
}
