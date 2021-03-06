﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step125Video
{

    public class TwentyOneGame : Game, IWalkAway
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
        

        //Commenting a function-as shown by Garth, not relevant to the video notes:
        /**
         * WalkAway takes in a player object and throws         //What it does
         * @input - player - a Player Object                    //What's going into it  
         * @returns a                                           //What's coming out
         */
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
