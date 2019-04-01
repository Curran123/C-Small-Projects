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
            int l = Convert.ToInt32(Console.ReadLine());//ReadLine litterally reads the line the users inputs.
            
            Console.ReadLine();




            Console.WriteLine("6, 10, 4");
            Console.WriteLine("What number do you want to do math on? Choose another.");
       
            

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


        

            
         

    



            



           
     