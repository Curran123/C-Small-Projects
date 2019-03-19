using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step67Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Screen");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string input = Console.ReadLine();
            int Input = Convert.ToInt32(input);
            Console.WriteLine("Hours worked per week");
            string ainput = Console.ReadLine();
            int aInput = Convert.ToInt32(ainput);
            int product = aInput * Input; //Weekly Rate for Person 1
            product = 52 * product; //Product is now equal to Weekly Rate * 52 
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string binput = Console.ReadLine();
            int bInput = Convert.ToInt32(binput);
            Console.WriteLine("Hours worked per week");
            string cinput = Console.ReadLine();
            int cInput = Convert.ToInt32(cinput);
            int product2 = cInput * bInput;
            product2 = 52 * product2;
            Console.WriteLine(product2);
            Console.ReadLine();



            //Console.WriteLine("Annual salary of Person 1");
            //Console.WriteLine();
            //Console.WriteLine();   //$31,200

            //Console.WriteLine("Annual salary of Person 2");
            //Console.WriteLine();
            //Console.WriteLine();   //$41,600

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (product > product2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}
