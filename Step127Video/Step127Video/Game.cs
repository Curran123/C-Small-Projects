using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step127Video
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }


        public abstract void Play();




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
