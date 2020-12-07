using System;

namespace _04.SubStringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string subString = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i <= text.Length - subString.Length; i++)
            {
                if(text.Substring(i, subString.Length) == subString)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
