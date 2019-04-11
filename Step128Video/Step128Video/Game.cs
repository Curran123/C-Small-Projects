using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step128Video
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }


        public abstract void Play();

        //Lists have to be instantiated first before adding to them.


        public virtual void ListPlayers()//A "virtual method" inside of an abstract class
        //means this method gets inherited by an inheriting class, but it has the 
        //ability to override it. Virtual methods have implementation,
        //but they can be overridden.
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
