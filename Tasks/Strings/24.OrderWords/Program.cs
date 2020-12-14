using System;

namespace _24.OrderWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            quickSort(words, 0, words.Length - 1);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

        }

        static int partition(string[] array, int low, int high)
        {
            string pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                int compare = string.Compare(array[j], pivot);
                if(compare == -1)
                {
                    i++;
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

            }

            string temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        static void quickSort(string[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = partition(array, low, high);
                quickSort(array, low, middle - 1);
                quickSort(array, middle + 1, high);
            }
        }
    }
}
