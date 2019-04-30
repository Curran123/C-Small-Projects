using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step134Exercise
{


    public class DaysOfTheWeek
    {
        public Day day { get; set; }

        public enum Day
        {
            Sunday = 2,
            Monday = 4,
            Tuesday = 6,
            Wednesday = 8,
            Thursday = 10,
            Friday = 12,
            Saturday = 14,
        }
    }
}
