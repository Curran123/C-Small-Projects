using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step127Video
{
    public class Dealer
    {

        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int MyProperty { get; set; }

        public void Deal(List<Card> Hand)//Giving the dealer class the ability to deal.
                                         //Takes a list of cards as an input parameter, and adds a card to that hand.
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
