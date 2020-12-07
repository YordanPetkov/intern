using System;

namespace _01.StringsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A string is an object of type String whose value is text.");
            string s = "Hello world!";
            Console.WriteLine(s.Substring(6, 5));
            Console.WriteLine(s.Replace("world", "Peter"));
            Console.WriteLine(s.IndexOf("w"));
            Console.WriteLine(s.ToUpper());
        }
    }
}
