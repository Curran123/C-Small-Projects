using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step128Video //OPERATOR OVERLOADING
{
    class Program
    {
        static void Main(string[] args)
        {
            //Talking about - * + operators.
            //The operators would be specific to an object you created.
            //What if you wanted to add two objects together?
            //Or use the + sign to add a player to a game?
            //Go to the Player tab to see this, then return here.

            Game game = new TwentyOneGame();
            game.Players = new List<Player>();//Instantiated the list, now we can 
            //add players to it.
            Player player = new Player();
            player.Name = "Jesse";
            game += player; //Means the exact same thing as "game = game + player;"
            game -= player; //Means the exact same things as "game = game - player;"
            //This way, you are not repeating yourself.

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
