using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step125Video
{
    class Program
    {
        static void Main(string[] args)//An "INTERFACE" is very similar to an abstract class, 
            //since there are no implementation details,
            //but the .NET Framework does not support multiple inheritance: one class can only inherit from 
            //one other class.
        {
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
