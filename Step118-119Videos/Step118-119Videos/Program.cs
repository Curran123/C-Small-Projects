using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step118_119Videos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance: one of the three pillars of OOP.
            //The ability of a class to inherit other properties 
            //and methods from another class.
            //If you can inherit properties and methods of another class,
            //you don't have to type it all out again.
            Game game = new Game();
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" }; //when typing, properties inherited 
            //will appear in drop-down list.
            game.ListPlayers();
            Console.ReadLine();
            //Called the "Super Class Method" above: When you call a class you are inheriting from. 

            
            
            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
