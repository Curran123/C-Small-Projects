using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step92Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();


            Console.WriteLine("What is the weight of the package?");
            string weightinput = Console.ReadLine();
            int weightInput = Convert.ToInt32(weightinput);



            



            if (weightInput > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via PackageExpress. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
            
            Console.WriteLine("What is the width of the package?");
            string widthinput = Console.ReadLine();
            double widthInput = Convert.ToInt32(widthinput);

            Console.WriteLine("What is the length of the package?");
            string lengthinput = Console.ReadLine();
            double lengthInput = Convert.ToInt32(lengthinput);

            Console.WriteLine("What is the height of the package?");
            string heightinput = Console.ReadLine();
            double heightInput = Convert.ToInt32(heightinput);

            double dimensionaltotal = (widthInput + lengthInput + heightInput);

            if (dimensionaltotal > 50) 
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
                Environment.Exit(0);
            }

           

            double Quote = ((dimensionaltotal * weightInput) / 100);

            var b = string.Format("Your estimated total for shipping this package is: {0:C}", Quote);
            Console.WriteLine(b);
            Console.ReadLine();

            Console.WriteLine("Thank you.");
            Console.ReadLine();



                    
            
            
        }
    }
}
