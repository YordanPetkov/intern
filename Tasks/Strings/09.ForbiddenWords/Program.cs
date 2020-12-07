using System;
using System.Text;

namespace _09.ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            string input = Console.ReadLine();
            string[] forbiddenWords = input.Split(',');

            foreach (string word in forbiddenWords)
            {
                StringBuilder asterisks = new StringBuilder();
                asterisks.Append('*', word.Length);
                text.Replace(word, asterisks.ToString());
            }

            Console.WriteLine(text.ToString());
        }
    }
}
