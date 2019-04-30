using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step132Video
{
    public class Card
    {
       

        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit
    {   //The underlying value is assigned in order and starts with 0.
        //Clubs starts at 0, Diamonds 1, Hearts 2, Spades 3.
        //However, you can assign whatever value you want.
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    //If you wanted to compare different values of enum, by having an 
    //underlying data type of int, you can compare in a 
    //very specific and exact way.



    public enum Face //Face also has a very limited amount of possibilities.
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
