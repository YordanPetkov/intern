using System;

namespace _12.ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string protocol = input.Substring(0, input.IndexOf("://"));
            int indexOfFirstSlash = input.IndexOf('/', input.IndexOf("://") + 3);
            string server = input.Substring(input.IndexOf("://") + 3, indexOfFirstSlash - input.IndexOf("://") - 3);
            string resource = input.Substring(indexOfFirstSlash);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
