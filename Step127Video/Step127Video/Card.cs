using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step127Video
{
    public class Card
    {
        //Constructor: values assigned to an object upon creation
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; } //The card class has a property of data type string call "suit"
        //which you can get or set
        //"public" means accessible to other parts of the program
        public string Face { get; set; }
        //Classes are like cookie cutters, while objects are like cookies
    }
}
