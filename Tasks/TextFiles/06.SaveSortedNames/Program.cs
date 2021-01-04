using System;
using System.Collections.Generic;
using System.IO;

namespace _06.SaveSortedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<String> words = new List<String>();
                var reader = new StreamReader("../../../List.txt");
                string line = reader.ReadLine();

                while (line != null)
                {
                    words.Add(line);
                    line = reader.ReadLine();
                }

                reader.Close();
                words.Sort();
                var writer = new StreamWriter("../../../SortedList.txt");

                foreach (string word in words)
                {
                    writer.WriteLine(word);
                }

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
