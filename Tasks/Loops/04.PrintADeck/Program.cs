using System;

namespace _04.PrintADeck
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cardFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] cardSuits = { "spades", "clubs", "hearts", "diamonds" };
            string inputCard;
            bool isCard = false;

            inputCard = Console.ReadLine();
            foreach (string face in cardFaces)
            {
                if(isCard == false)
                {
                    for (int i = 0; i < cardSuits.Length; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("{0} of {1}", face, cardSuits[i]);
                        }
                        else
                        {
                            Console.Write(",{0} of {1}", face, cardSuits[i]);
                        }
                        
                    }
                    Console.WriteLine();
                }

                if (inputCard == face)
                {
                    isCard = true;
                }

            }
        }
    }
}
