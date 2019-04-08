using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step126Exercise
{
    class Employee : IQuittable
    {
        

        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public virtual void Quit()//The Quit Method
        {
            Console.WriteLine(FirstName  + MiddleName);
        }





        public class IQuittable//Polymorphism example
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //public virtual void Change()
            //{
            //    Employee e = new Employee(); //FirstName
            //    string n = (e.FirstName);
            //    Employee g = new Employee(); //LastName
            //    string t = (g.MiddleName);

            //    bool FirstNameOperand()
            //    {
            //        int p = Convert.ToInt32(e);
            //        e = true;
            //        return true;
            //    }

            //    if (e & g "{0}")




            //    Console.WriteLine("I like that name!");
            //}

        }





    }
}
