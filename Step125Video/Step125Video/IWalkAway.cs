using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step125Video
{
    interface IWalkAway
    {
        //The .NET Framework supports multiple inheritance of interfaces.
        //Everything is public in an interface. 
        //The naming convention for interfaces is to start with an uppercase "I".
        void WalkAway(Player player);

    }
}
