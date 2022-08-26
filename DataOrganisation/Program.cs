using System;
using System.Collections.Generic;

namespace DataOrganisation
{
    class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                List<Card> cards = new List<Card>();
                Console.Write("\nEnter the number of random cards you would like: ");
                if (int.TryParse(Console.ReadLine(), out int numberOfCards))
                {
                    for (int i = 0; i < numberOfCards; i++)
                    {
                        cards.Add(RandomCard());
                    }
                }
                else return;
                PrintCards(cards);
                cards.Sort(new CardComparerByValue());
                Console.WriteLine("\n... sorting cards ...\n");
                PrintCards(cards);
            }
        }

        public static Card RandomCard()
        {
               return new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
        }

        public static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                //Console.WriteLine(card.Name);
                //overloaded Console.WriteLine method that calls the object's overriden ToString() method 
                Console.WriteLine(card);
            }
        }

    }
}
