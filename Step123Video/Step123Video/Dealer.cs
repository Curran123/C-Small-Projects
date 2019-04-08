using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step123Video
{
    public class Dealer //An abstract class is a class marked with the keyword "abstract".
        //It can NEVER BE INSTANTIATED (CAN NEVER BE AN OBJECT).
        //ONLY MEANT TO BE INHERITED FROM.
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
