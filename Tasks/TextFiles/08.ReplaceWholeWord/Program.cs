using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _08.ReplaceWholeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var reader = new StreamReader("../../../text.txt");
                var writer = new StreamWriter("../../../result.txt");
                string line = reader.ReadLine();

                while (line != null)
                {
                    line = Regex.Replace(line, @"\bstart\b", "finish");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }

                reader.Close();
                writer.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }
        }
    }
}
