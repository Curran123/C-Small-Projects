using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step130Video
{
    class Program //GENERICS
    {

        static void Main(string[] args)
        {

            //Generics are a feature of the language that allows you to write
            //generic classes or functions, which by nature, are more generalized
            //and less specific.
            //The more generic you can make something, the more you can reuse it.
            //For example, a list data type is generic; what goes in the brackets
            //is the data type the list is containing.
            //This is done in the definition of the list class.

            //List<Game> for example, instead of hardcoding a data type, they use
            //List<T>, which represents the data type that will be passed in upon 
            //object creation; List<T> is useable for every kind of data type.
            //Go to the Player class to see this.

            Player<Card> player = new Player<Card>();//When we create the Player object, 
            //we pass in the data type we want the Hand to hold.
            player.Hand = new List<Card>();
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

            //The most common usage of generics is inside of the list class.

            //NOTE: If you want to see if your program will run without 
            //actually running it, you can build it, which is the same as compiling it.


        }
    }
}
