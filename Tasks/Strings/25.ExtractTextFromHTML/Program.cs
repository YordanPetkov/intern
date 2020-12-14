using System;
using System.Text.RegularExpressions;

namespace _25.ExtractTextFromHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string HTMLText = " ";
            string line;

            while ((line = Console.ReadLine()) != null)
            {
                HTMLText += line + " ";
            }

            Regex regexTitle = new Regex("<title.*?>(.*?)<\\/title>", RegexOptions.IgnoreCase);
            Regex regexBody = new Regex("<body.*?>(.*?)<\\/body>", RegexOptions.IgnoreCase);
            Regex regex = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            string title = regexBody.Replace(HTMLText, "");
            string body = regexTitle.Replace(HTMLText, "");
            Console.WriteLine("title : {0}", regex.Replace(title, "").Trim());
            Console.WriteLine("text : {0}", regex.Replace(body, "").Trim());
        }
    }
}
