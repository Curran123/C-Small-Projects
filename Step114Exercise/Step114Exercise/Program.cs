using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step114Exercise
{
    class Program
    {
        static void Main(string[] args)
        {


            //first method
            Console.WriteLine("Give me something");
            int r = Convert.ToInt32(Console.ReadLine());


            Math p = new Math();

            
            int first = p.MathMethod(r);//calling the method within the class; setting return value to "first"
            Console.WriteLine("The sum is {0}", first); //first is equal to the sum


            //PASS MEANS TO pass one variable to another to work with.



            //second method
            Console.WriteLine("Give me something else, namely a decimal");
            double q = Convert.ToDouble(Console.ReadLine());
           
           
            double second = p.MathMethod(q);
            Console.WriteLine("The sum is {0}", second);







            //third method
            Console.WriteLine("Give me one last thing");
            string t = Convert.ToString(Console.ReadLine());



            int MathMethod = 0;
            string mathmethod = Convert.ToString(MathMethod);
            string third = p.MathMethod(t);
            Console.WriteLine("The sum is {0}", third);

            Console.ReadLine();
            
           
        }
    }   
}
