using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step110Video
{
    public class Deck
    {
        //This is a constructor
        public Deck()
        {

            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //Loops through both simultaneously to generate a deck of 52
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card); //Add new card to card list
                }
            }
        }
        public List<Card> Cards { get; set; }//the property

        //an object can do things (behavior)

        //The Shuffle Method
        //I want this method to act on the object in which it
        //it attached to. I want it to shuffle the deck I just created.
        //You can call this method w/o it applying to this specific deck.
        //get rid out static and out parameter
        public void Shuffle(int times = 1) //all it does is take one parameter
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)//we don't need to preface cards with deck, because
                                       //it is already operating on the object on which it exists.
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList;
            }

        }
    }
}
