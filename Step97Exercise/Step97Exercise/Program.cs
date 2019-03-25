using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step97Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder("My ");
            sb.Append("Name ");
            sb.Append("For Your Reference ");
            sb.Append(", and please remember it ");
            sb.Append("is ");
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());




            string firstName = "peter";
            string middleName = "curran";
            string lastName = "o'meara";

            
            



            string lower = (firstName) + " " + (middleName) + " " + (lastName);
            Console.WriteLine(lower.ToUpper());
            Console.ReadLine();
            
            

        }
    }
}
