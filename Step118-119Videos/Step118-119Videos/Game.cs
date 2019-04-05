using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step118_119Videos
{
    public class Game
    {
        //Note: "Design Toward Abstraction": the more generic you can make your code,
        //the easier it is to add features to it later;
        //If we start with something generic like "Game", including only the properties,
        //specific to all games, when we go to build another class, we are 
        //setting ourselves up for success later.

        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
