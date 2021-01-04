using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var reader = new StreamReader("../../../Tasks.txt"))
                {
                    int countRows = 0;
                    string line = reader.ReadLine();

                    while(line != null)
                    {
                        countRows++;
                        if(countRows % 2 == 1)
                        {
                            Console.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                    
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read :");
                Console.WriteLine(e.Message);
            }
        }
    }
}
