using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124Exercise
{
   abstract class Person
   {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        
        
        public virtual void SayName()
        {
            Console.WriteLine(Firstname + Lastname);
            //Console.WriteLine("Name: " + firstName + " " + lastName);
        }
   }
}
