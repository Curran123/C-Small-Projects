using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step127Video//DEBUGGING
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }//To DEBUG, you put in break points, which tells Visual Studio to 
        //"stop here".

        //The Step Over button means "Go to the next line".

        //You may see what the value is of something at particular times.

        //Ctrl Shift F9 will get rid of all break points.
    }
}
