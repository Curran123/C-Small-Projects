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

            StringBuilder sb = new StringBuilder("MY", 10);
            sb.Append(new char[] { 'N', 'A', 'M', 'E', 'I', 'S' });
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());




            string firstName = "peter";
            string middleName = "curran";
            string lastName = "o'meara";

            
            



            string lower = "peter" + "curran" + "o'meara";
            Console.WriteLine(lower.ToUpper());
            Console.ReadLine();
            
            

        }
    }
}
