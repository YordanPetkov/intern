using System;
using System.Text.RegularExpressions;

namespace _19.DatesFromTextInCanada
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            var regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1]).(0[1-9]|1[0-2]).((19|20)\d\d))$");

            foreach (string word in words)
            {
                if (regex.IsMatch(word))
                {
                    string[] dateParts = word.Split('.');
                    DateTime date = new DateTime(int.Parse(dateParts[2]), int.Parse(dateParts[1]), int.Parse(dateParts[0]));
                    Console.WriteLine("{0:yyyy-MM-dd}", date);
                }
            }

        }
    }
}
