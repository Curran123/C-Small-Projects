using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step75Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dui = false;
            Console.WriteLine("What is your age?");
            string input = Console.ReadLine();
            int Input = Convert.ToInt32(input);
            Console.WriteLine("Have you ever had a DUI?");
            string dinput = Console.ReadLine();
            dinput = dinput.ToLower();
            if (dinput == "no"){
                dui = true; 
            }
            Console.WriteLine("How many speeding tickets do you have?");
            string sinput = Console.ReadLine();
            int sInput = Convert.ToInt32(input);



            //int age = 14;
            //int speedingticket = 4;
            //bool dui = true;
            


            bool carinsurance = (Input > 15 && sInput < 3 && dui);
            if (carinsurance == true)
            {
                Console.WriteLine("You are qualified for car insurance.");
            }
            else
            {
                Console.WriteLine("You are not qualified for car insurance.");
            }
            Console.WriteLine(carinsurance);
            Console.ReadLine();
            
            
            
            
            //Console.WriteLine("What is your age?");
            //bool age = true;
            //Console.WriteLine(age);
            //bool time = 8 > 5;
            //Console.WriteLine(time);
            //Console.ReadLine();
        }
    }
}
