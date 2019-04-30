using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step132Video
{
    public abstract class Game
    {
        public string Name { get; set; }
        public string Dealer { get; set; }


        public abstract void Play();
    }
}
