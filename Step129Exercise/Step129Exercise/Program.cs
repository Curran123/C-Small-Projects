using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step129Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Id1 = new Employee(1, 2);
            Employee Id2 = new Employee(1, 2);

            if (Id1 == Id2)
                Console.WriteLine("They are the same");
            else
                Console.WriteLine("They are not the same");
            Console.ReadLine();
            


        }
    }
}
