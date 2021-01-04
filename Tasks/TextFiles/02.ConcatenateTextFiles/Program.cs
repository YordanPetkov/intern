using System;
using System.IO;

namespace _02.ConcatenateTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var firstFileReader = new StreamReader("../../../Paragraph1.txt");
                var storyFileWriter = new StreamWriter("../../../Story.txt", true);
                string line = firstFileReader.ReadToEnd();
                storyFileWriter.Write(line);
                firstFileReader.Close();
                var secondFileReader = new StreamReader("../../../Paragraph2.txt");
                line = secondFileReader.ReadToEnd();
                storyFileWriter.Write(line);
                secondFileReader.Close();
                storyFileWriter.Close();
            }

            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }
        }
    }
}
