using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step111Exercise
{
    class Program
    {

        


        static void Main(string[] args)
        {


            Console.WriteLine("Write a number");
            int l = Convert.ToInt32(Console.ReadLine());//ReadLine literally reads the line the users inputs.
            
       



            Console.WriteLine("6, 10, 4");
            Console.WriteLine("I will now multiply your number by 6, 10, and 4");
       
            

            Multiply n = new Multiply();

            //calling the first method
            int ret = n.MultiplyOne(l);
            Console.WriteLine("The product is {0}", ret);
            Console.ReadLine();


            //calling the second method
            int set = n.MultiplyTwo(l);
            Console.WriteLine("The product is {0}", set);
            Console.ReadLine();

            //calling the third method
            int jet = n.MultiplyThree(l);
            Console.WriteLine("The product is {0}", jet);
            Console.ReadLine();







        }

    }
}


        

            
         

    



            



           
     