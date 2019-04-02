using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step110Video //MORE METHODS
    //METHOD OVERLOADING: create as many functions as you want 
    //with the same name as long as they are kind of different.
    //Compiler has specific rules to determine which one to use.
    //take deck as parameter AND integer called "times", 
    //which is number of times deck wil be shuffled.
    //In this example, we are shuffling 3 times
{
    class Program
    {
        static void Main(string[] args)
        {




            //Deck deck = new Deck();
            //deck = Shuffle(deck);
            //deck = Shuffle(deck, 3); //new method for this video
            //shuffle 3 times

            //When calling a method, use can use a named parameter, to make
            //it a little easier to read. 
            //Deck deck = new Deck();
            //int timesShuffled = 0;
            //deck = Shuffle(deck: deck, times: 3);

            //Out parameter example
            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);//shuffles deck
            //3 times and returns value "timesShuffled = 0;"
            //but it is not returning it to deck, it is sending it out and assigning
            //it to int "timesShuffled = 0;"
           

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times Shuffled {0}", timesShuffled);
        }

        //An "out parameter", rather than returning a value, the method 
        //throws it back to the variable when the method is done.
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times= 1) //If someone does not enter
            
            
            //in a parameter, it will assume it is 1 
            //If so, you now made that parameter optional.
            
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
            
            return deck;
            
            //grab a random card, take it out of the deck and put it into a temporary deck
            //done when deck.Cards.Count is at 0. //FROM PREVIOUS VIDEO
        }
        
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }  
}   
