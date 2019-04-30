using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step134Exercise
{
    class Program
    {


        public enum Day
        {
            Sunday, 
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        public static void Main(string[] args)
        {
            //bool IsDay = false;

            Console.WriteLine("Please enter the current day of the week");

            string value = Console.ReadLine();

            bool number = int.TryParse(value, out int input); //testing whether or not what has been entered is a number.


            try
            {


                if (!number) //If what has been entered is NOT a number...
                {
                    Day day = (Day)Enum.Parse(typeof(Day), value); //comparing what the user entered against each individual part of the enum.
                    Console.WriteLine(day);
                }
                else //If what was entered WAS a number...
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
                

                

                
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                
            }
            Console.ReadLine();
        }   
    }
}