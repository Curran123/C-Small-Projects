using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step135_136Exercise
{
    public struct Card//Once you set the value of a card, you wouldn't want it changing
        //as you would with reference types.
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit
    {
        
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face 
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
