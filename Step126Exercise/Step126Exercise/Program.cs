using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step126Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will now enter your first and middle names");

            Employee n = new Employee("Zach", "Ahern");//POLYMORPHISM: CLASS IS SLIGHTLY DIFFERENT FROM 
           
            
            //THE INTERFACE
            n.Quit();
            Console.ReadLine();

        }
    }
}
