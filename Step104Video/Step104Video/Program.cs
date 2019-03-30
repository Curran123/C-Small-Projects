using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step104Video
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXCEPTION HANDLING PART ONE & TWO


            //Exceptions are when something goes wrong in your code. 
            //From a UX perspective, you don't want the user to see something go wrong it the code.
            //In this example, if you put in "Jesse", you will get "Input string was not in a correct format.
            
            //Console.WriteLine("Pick a number.");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Pick a second number. ");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dividing the two...");
            //int numberThree = numberOne / numberTwo;
            //Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //Console.ReadLine();

            //We solve exception handling through a trycatch block

            //It essentially says "Let's try this, but catch any exceptions"

            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number. ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) //Only catching a format exception, and assigning it the variable "ex", which is a datatype format exception
            {
                Console.WriteLine(ex.Message); //Could write "Please type a whole number" to customize UX
            }
            

            //different error
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //Runs no matter what. However, does not catch errors which could be logged for other purposes.
                    
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }   
    }
}
