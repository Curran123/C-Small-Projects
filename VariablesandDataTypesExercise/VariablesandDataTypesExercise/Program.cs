using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDataTypesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");


            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();
            
            

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pNumber = Convert.ToInt32(pageNumber);
            int total = pNumber;
           

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string helpAnswer = Console.ReadLine();
            

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveAnswer = Console.ReadLine();
          

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific?");
            string feedbackAnswer = Console.ReadLine();
           
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int sHours = Convert.ToInt32(studyHours);
            int sum = sHours;

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
