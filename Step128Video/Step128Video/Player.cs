using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step128Video
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //overload the + operator first; want to make it so it will just 
        //be "game + player" and it will add the player into the game.

        //We are overloading operator+, it is taking two operands, a game and a player,
        //it's returning a game, and it then takes the game and adds player to it, and
        //returns game.
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        //Overloading the minus operator
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player); //State item you want removed from list.
            return game;
        }
    }
}
