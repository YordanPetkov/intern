using System;
using System.Text.RegularExpressions;

namespace _18.ExtractE_Mails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            foreach (string word in words)
            {
                if(regex.IsMatch(word))
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
