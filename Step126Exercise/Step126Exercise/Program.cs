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
            IQuittable n = new Employee();//POLYMORPHISM: CLASS IS SLIGHTLY DIFFERENT FROM 
            //THE INTERFACE
            n.Quit();

        }
    }
}
