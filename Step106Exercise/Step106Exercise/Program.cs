using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Numbers.Add(0);
            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(4);
            Numbers.Add(5);
            Numbers.Add(6);

            //Console.WriteLine(0);
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            List<int> Numbers2 = new List<int>(); //Second List
            Console.WriteLine("Please select a number to divide each other number by");
            int count = 0;
            String n = Console.ReadLine();
            int z = Convert.ToInt32(n);
            

            foreach (int s in Numbers)

            {

                Numbers2.Add(s / z);
                Console.WriteLine(s);

            }
            foreach (int s in Numbers2)

            {

               
                Console.WriteLine(s);

            }
            Console.ReadLine();
        }
    }
}
