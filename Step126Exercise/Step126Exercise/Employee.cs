using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step126Exercise
{
    class Employee: IQuittable
    {
        

        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public Employee()//A class constructor
        {
            FirstName = ("Bob");
            MiddleName = ("Jenkins");
        }
        public Employee(string x, string y)//A class constructor
        {
            FirstName = (x);
            MiddleName = (y);
        }

        public virtual void Quit()//The Quit Method
        {
            Console.WriteLine(FirstName + " " + MiddleName);
        }

        



        
        





    }
}
