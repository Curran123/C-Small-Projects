using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step135_136Exercise
{
    public class Deck
    {
        public Deck()
        {
            //Goal is to create a fully populated deck.

            Cards = new List<Card>();

            //forloops so we can access particular integers of enums as a 
            //reference point.

            for (int i = 0; i < 13; i++)//We'll want to loop through each of the faces.
                                        //Once "i" equals 13, this for loop kicks off.
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;//13 possible faces
                    card.Suit = (Suit)j;//4 possible suits
                    Cards.Add(card);
                }
            }



        }
        public List<Card> Cards { get; set; }


        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
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
