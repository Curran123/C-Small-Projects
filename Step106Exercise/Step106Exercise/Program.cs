using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ABOVE ARE LIBRARIES IN USE.  

namespace Step106Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //STEP 1.
            //Create a list of integers. Ask the user for a number to divide each number in the list by. 
            //Write a loop that takes each integer in the list, divides it by the number the user entered, 
            //and displays the result to the screen.


            List<int> Numbers = new List<int>();
            Numbers.Add(20);
            Numbers.Add(18);
            Numbers.Add(16);
            Numbers.Add(14);
            Numbers.Add(12);
            Numbers.Add(10);
            Numbers.Add(4);

            //Console.WriteLine(0);
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);

            Console.WriteLine("Please select a number to divide each other number by");

            //string n = Console.ReadLine();
            try {
                int z = Convert.ToInt32(Console.ReadLine()); //Whatever user enters, immediately convert it to an integer
                                                             //and set it to "z". You don't need "n" above




                try
                {
                    foreach (int s in Numbers) { //"s" creates a variable to iterate with



                        Console.WriteLine(s / z);

                    }
                    Console.ReadLine();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("You cannot enter zero");

                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You cannot enter a string");
                Console.ReadLine();
            }
        }   
    }
}
