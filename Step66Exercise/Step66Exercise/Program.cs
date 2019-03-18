using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step66Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in a number");
            string input = Console.ReadLine();
            int Input = Convert.ToInt32(input);
            int product = Input * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Put in another number");
            string ainput = Console.ReadLine();
            int aInput = Convert.ToInt32(ainput);
            int total = aInput + 25;
            Console.WriteLine(total);
            Console.ReadLine();

            Console.WriteLine("Put in yet another number");
            string binput = Console.ReadLine();
            int bInput = Convert.ToInt32(binput);
            Console.WriteLine(bInput / 12.5);
            Console.ReadLine();

            Console.WriteLine("Once more, put in a number");
            string cinput = Console.ReadLine();
            int cInput = Convert.ToInt32(cinput);
            if (cInput > 50)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.Write("False");
            }
            Console.ReadLine();

            Console.WriteLine("'Knock Knock,' 'Who's There?' 'ANOTHER NUMBER PLEASE'");
            string dinput = Console.ReadLine();
            int dInput = Convert.ToInt32(dinput);
            Console.WriteLine(dInput / 7);
            Console.ReadLine();
            Console.WriteLine(dInput % 7);
            Console.ReadLine();
        }

    }

}
