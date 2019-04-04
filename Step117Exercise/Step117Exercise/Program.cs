using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step117Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //first method
            Console.WriteLine("Give me a number, and I will divide it by 2");
            int y = Convert.ToInt32(Console.ReadLine());

            Divide d = new Divide();

            int first = d.DivideMethod(y);
            Console.WriteLine("The quotient is {0}", first);
            Console.ReadLine();



            //second method
            //using out parameters
            Console.WriteLine("I will now display a game and its rating. But first, please guess the rating");
            string o = Convert.ToString(Console.ReadLine());

            Divide p = new Divide();

            p.Game(o, out string gamename, out string gamerating);

            Console.WriteLine("Guess: {0}, Game: {1}, Rating: {2}",o, gamename, gamerating);
            Console.ReadKey();



            //third method
            Console.WriteLine("Lastly, please give me a decimal, and I will add it by 5.5");
            double q = Convert.ToDouble(Console.ReadLine());

            double third = d.DivideMethod(q);
            Console.WriteLine("The sum is {0}", third);
            Console.ReadLine();
            
            
          

            
        }
    }
}
