using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step125Video
{
    public class TwentyOneGame : Game
    {
        public override void Play()//Use "override" to get the method ("PLAY" IN "GAME") defined.
        {
            throw new NotImplementedException();//Don't want this method called.
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();//Equivalent to what is happening to 
            //"public virtual void ListPlayers()" in "Game".
        }
    }
}
