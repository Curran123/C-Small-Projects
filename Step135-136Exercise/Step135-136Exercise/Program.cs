using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step135_136Exercise
{
    class Program       //STRUCTS PART ONE & TWO
    {
        //Every data type in C# is either a reference or value type.
        
        static void Main(string[] args)
        {
            

            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;
            //The result from executing is "King"
            //When creaing card2, you assumed that you were creating a new card object 
            //independent from card1.
            //A class is like a blueprint, and when we instantiate a class, all we do is
            //allocate a block of memory and configuring it according to that blueprint.
            //But, when we assigned the value of card1 to card2, we didn't actually create
            //a new block of memory.
            //Instead, we gave card2 the address to the memory location of card1 and said,
            //"here you go" or "look here and change the value in this address if
            //you want to change your own value."
            //All classes in C# operate by reference. Any classes you create yourself,
            //such as card1, but also those that come prebuilt by the framework class 
            //library, such as the "List" class.
            //Any data type that stores value by reference is called a reference types, which
            //includes all classes.
            //With vaule types, you have created a seperate, independent instance. 
            //Integers, booleans, enums, and daytime are value types.
            //An integer is not a class, it is a STRUCT, which is a class that is a value type;
            //it also cannot be inherited.
            //Value types (and structs) cannot have a value of null.
            //Go to card class now to see how problem is fixed.

            //card1 & card2 are now completely seperate. 
            Console.WriteLine(card1.Face);

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
