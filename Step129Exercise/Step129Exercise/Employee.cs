using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step129Exercise
{
    public class Employee
    {
       
        public int Id { get; set; }


        public Employee()
        {
         
           

            Id = 0;
            Id = 0;
         
        }
        public Employee(int y, int c)
        {
          
            Id = (y);
            Id = (c);
            

        }
        
        public static bool operator == (Employee y, Employee c)
        {
            Console.WriteLine("Anything");
            if (y.Id == c.Id)
                
                return true;
            else
                return false;
        }
        
        public static bool operator != (Employee y, Employee c)
        {
            if (y.Id != c.Id)
                return true;
            else
                return false;
        }
        
        public int getValue()
        {
            return Id;
        }
        

    }
}
