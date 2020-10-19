using System;
using System.Collections.Specialized;

namespace _08.IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            char copyright = '\u00a9';
            int numRows = 4;
            int spaces;
            int spacesOnRow ;

            Console.WriteLine("Number of rows  : " + numRows);

            spaces = numRows - 1;
            spacesOnRow = spaces;
            for (int row = 0; row < numRows; row++)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }

                

                if(row == numRows - 1)
                {
                    for (int i = 0; i < numRows; i++)
                    {
                        Console.Write(copyright + " ");
                    }
                }

                else if(row == 0)
                {
                    Console.Write(copyright);
                }

                else
                {
                    Console.Write(copyright);

                    for (int i = 0; i < spacesOnRow - spaces; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(copyright);
                    spacesOnRow++;
                }

                Console.WriteLine();
                spaces--;

            }
        }
    }
}
