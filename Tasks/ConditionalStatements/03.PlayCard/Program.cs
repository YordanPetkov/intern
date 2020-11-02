using System;

namespace _03.PlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cardFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            string card;
            bool isCard = false;
            card = Console.ReadLine();
            foreach (string c in cardFaces)
            {
                if(card == c)
                {
                    isCard = true;
                    break;
                }
            }
            if(isCard == true)
            {
                Console.WriteLine("yes {0}", card);
            }
            else
            {
                Console.WriteLine("no {0}", card);
            }
        }
    }
}
