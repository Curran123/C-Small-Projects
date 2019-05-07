using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step131Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();//Instantiating 
            //the class

            employee.Things = new List<string>();//Creating the list.
            employee.Things.Add("Concomitants");
            employee.Things.Add("Tableaus");
            employee.Things.Add("Monads");

            Employee<int> Employee = new Employee<int>();
            
            Employee.Things = new List<int>();
            Employee.Things.Add(7);
            Employee.Things.Add(8);
            Employee.Things.Add(9);
            Employee.Things.Add(10);


            foreach (string e in employee.Things)
            {
                Console.WriteLine(e);                
            }
            foreach (int g in Employee.Things)
            {
                Console.WriteLine(g);
            }
            Console.ReadLine();

        }
    }
}
