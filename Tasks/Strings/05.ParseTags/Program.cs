using System;
using System.Text;

namespace _05.ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            string text = Console.ReadLine();
            StringBuilder inputText = new StringBuilder(text);
            int[][] openTagsIndexes = Find(openTag, text);
            int[][] closeTagsIndexes = Find(closeTag, text);

            for (int i = 0; i < openTagsIndexes[0][0]; i++)
            {
                int startIndex = openTagsIndexes[1][i] + openTag.Length;
                int endIndex = closeTagsIndexes[1][i];
                string temp = inputText.ToString().Substring(startIndex, endIndex-startIndex);
                inputText.Remove(startIndex, endIndex - startIndex);
                inputText.Insert(startIndex, temp.ToUpper());
            }

            int deltaIndex = 0;

            for (int i = 0; i < openTagsIndexes[0][0]; i++)
            {
                inputText.Remove(openTagsIndexes[1][i] + deltaIndex, openTag.Length);
                deltaIndex -= openTag.Length;
                inputText.Remove(closeTagsIndexes[1][i] + deltaIndex, closeTag.Length);
                deltaIndex -= closeTag.Length;
            }

            Console.WriteLine(inputText.ToString());
        }

        static int[][] Find(string subString, string text)
        {
            int[][] indexes = new int[2][];
            indexes[0] = new int[1];
            indexes[1] = new int[text.Length / subString.Length];

            int counter = 0;

            for (int i = 0; i <= text.Length - subString.Length; i++)
            {
                if (text.Substring(i, subString.Length) == subString)
                {
                    indexes[1][counter++] = i;
                }
            }

            indexes[0][0] = counter;
            return indexes;
        }
    }
}
