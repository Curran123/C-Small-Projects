using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step121_122Videos
{
    //We are never going to have an instance of "Game". 
    //It is always going to be a specific game.
    //Poker, Solitaire, etc. inherit from the game class.
    //"Base" is another word for "abstract".
    //By adding "abstract", we've locked our code down.
    //We feel that there should be no instances of the "game" object
    //that we are making it impossible to do so.
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();//An abstract method can only exist inside an 
        //abstract class, and they contain no implementation.
        //All it does state that any class inheriting this class must implement
        //this method.
        //"TwentyOneGame" will implement this method somewhere in its class and it will have
        //that exact same name and return type and take those exact same parameters.


        public virtual void ListPlayers()//A "virtual method" inside of an abstract class
            //means this method gets inherited by an inheriting class, but it has the 
            //ability to override it. Virtual methods have implementation,
            //but they can be overridden.
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    } 
}
