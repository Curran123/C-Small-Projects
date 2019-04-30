using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step132Video
{
    class Program //ENUMS PART ONE & TWO
    {
        static void Main(string[] args)
        {

            //DaysOfTheWeek day = DaysOfTheWeek.Monday;
            //The value of this variable would have to be one of those below.
            //As a programmer, you don't have to worry about spelling,
            //name, Dark vs. Deep Purple.
            //The designer of class doesn't have to worry if their choosing
            //a supported color, because they have to choose one from the drop down
            //to even continue.

            //Card card = new Card();
            //card.Suit = Suit.Clubs; //Please see enum in Card tab.
            //Enums have an underlying data type.
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //We casted Suit.Diamonds to an integer.
            //Console.WriteLine(underlyingValue);//The underlying value is 1.


            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        
        //Enums is a data type.
        //When you say a piece of data is of type enum, 
        //it is a one in a set of named constants.
        //public enum DaysOfTheWeek
        //{
            //Monday,
            //Tuesday, 
            //Wednesday,
            //Thursday,
            //Friday,
            //Saturday,
            //Sunday
            
            //These are all of the possibilities that the data type can have.
            //Completely eliminates possiblity of user input error on that step.
        //}
    }
}
