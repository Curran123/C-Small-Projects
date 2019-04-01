using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps107_110Videos
{
    public class Deck
    {
        //This is a constructor
        public Deck()
        {
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

            //Easier way using a foreach loop.

            //for each face in that list of 13, we need to loop through it 4 times.
            //13 * 4 = 52; once for each suit.
            //the result wil be a "nested foreachloop"
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
        public List<Card> Cards { get; set; }
    }
}
