using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step110Video //CLASS METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
           //create methods that specifically belong to a class
           //accessing methods without creating an object of the class
           //first.



            Deck deck = new Deck();
            deck.Shuffle(3);//we call this method shuffle on itself
            //shuffles all of the cards existing inside of the deck in the deck class;

            
            

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) //THE METHOD
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
                //grab a random card, take it out of the deck and put it into a temporary deck
                //done when deck.Cards.Count is at 0.
                return deck;
            }
    }   
}
