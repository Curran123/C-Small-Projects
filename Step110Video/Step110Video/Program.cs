using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step110Video
{
    class Program
    {
        static void Main(string[] args)
        {
            //methods are blocks of reusable code that do something.
            //they have an access modifier (is this accessible everywhere in the program?),
            //a return type (return a value like an int),
            //and parameters or lack of parameters
            //They have to be used as part of a class,
            //and if they are used without first creating an object of that class,
            //they have to be marked as "static"



            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck) //THE METHOD
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while(deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
            //grab a random card, take it out of the deck and put it into a temporary deck
            //done when deck.Cards.Count is at 0.
        }
    }
}
