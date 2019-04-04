using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step115Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoIntegers p = new TwoIntegers();
            Console.WriteLine("Please give me a number");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give me a second number if you want");
            string j = Console.ReadLine();
            if (string.IsNullOrEmpty(j)) {
                Console.WriteLine(p.FirstTwo(k));//will just call the function with just one parameter.          
            }
            else
            {
                int J = Convert.ToInt32(j);
                Console.WriteLine(p.FirstTwo(k, J));
            }

          
            Console.ReadLine();
        }
    }
}
