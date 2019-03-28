using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step101Video
{
    class Program
    {
        static void Main(string[] args) //ITERATION PART 1 & 2
        {

            //Iteration is something you will do whenever you have a group of something.


            //FIRST EXAMPLE

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

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++ )
            //{
            //   Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();



            //THIRD EXAMPLE

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach(int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}
            //Console.ReadLine();




            ////FOURTH EXAMPLE

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();







            //FIFTH EXAMPLE
            //iterate over a list, and if something meets a certain condition, you are going to add it to another list.

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
                
        }  
    }
}
