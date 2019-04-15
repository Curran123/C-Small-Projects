using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step130Video
{
    //For example, adding generics to Player class will add needless complexity,
    //but is done to better explain generics. So, will add it in, then delete
    //it afterwards.

    public class Player<T>
    {
        //What if we wanted to use this player class in a roulette game? We
        //could not reuse the Player class, and we could not inherit from it because
        //we would have a useless property "Hand". 
        //There IS a way to make the Player class generic, where we would
        //define the data type that list would hold. Instead of "Hand" be a 
        //list of cards, since this is roulette, we can make it be a list of 
        //numbers.
        //We add <T> above and below.
        public List<T> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //public static Game operator +(Game game, Player player)
        //{
        //    game.Players.Add(player);
        //    return game;
        //}

        //public static Game operator -(Game game, Player player)
        //{
        //    game.Players.Remove(player); 
        //    return game;
        //}

    }
}
