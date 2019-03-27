using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step101Video
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 99, 94 }; //To iterate over an array in C#, create a for loop.

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();


            //SECOND EXAMPLE

            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j < names.Length; j++ )
            {
                if (names[j] == "Jesse")
                {
                    Console.WriteLine(names[j]);
                }
            }   Console.ReadLine();
        }   
    }
}
