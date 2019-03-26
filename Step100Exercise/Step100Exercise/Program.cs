using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step100Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1.

            string[] gamegenres = new string[10];
            gamegenres[0] = "JRPG";
            gamegenres[1] = "Turn-based strategy";
            gamegenres[2] = "RTS";
            gamegenres[3] = "FPS";
            Console.WriteLine("Array 1: " + gamegenres[0]);
            Console.WriteLine("Array 1: " + gamegenres[1]);
            Console.WriteLine("Array 1: " + gamegenres[2]);
            Console.WriteLine("Array 1: " + gamegenres[3]);
            

            Console.WriteLine("Please select an index from the array");
            string gamearrayinput = Console.ReadLine();
            string gamearrayInput = Convert.ToString(gamearrayinput);

            Console.WriteLine("You selected " + (gamearrayInput));
            Console.ReadLine();

            bool gamegenrefound = false; 
            for (int i = 0; i < gamegenres.Length; i++) // i is the current spot on the array we are looking at.
            {
                if (gamearrayinput == gamegenres[i]) //Check if input matches the current array index.
                {
                    Console.WriteLine("Great!");
                    Console.ReadLine();
                    gamegenrefound = true;
                }
                
                

            }

            if (gamegenrefound == false)
            {
                Console.WriteLine("That is not a index. Please enter an appropriate answer");
                Console.ReadLine();
            }



            //Step 2.

            Console.WriteLine("Moving onto the second array.");
            Console.ReadLine();

            int[] agenumArray = new int[4];
            agenumArray[0] = 6;
            agenumArray[1] = 9;
            agenumArray[2] = 15;
            agenumArray[3] = 18;

            Console.WriteLine(agenumArray[0]);
            Console.WriteLine(agenumArray[1]);
            Console.WriteLine(agenumArray[2]);
            Console.WriteLine(agenumArray[3]);
            Console.ReadLine();

            //alternate way
            //int[] agenumArray = new int[] { 6, 9, 15, 18 };


            Console.WriteLine("Please select an index from the array"); //Need to convert agearrayinput from a string to an integer.
            string agearrayinput = Console.ReadLine();
            int agearrayInput = Convert.ToInt32(agearrayinput);
            


            Console.WriteLine("You selected " + (agearrayinput));
            Console.ReadLine();

            bool agenumfound = false;
            for (int i = 0; i < agenumArray.Length; i++)
            {
                if (agearrayInput == agenumArray[i]) 
                {
                    Console.WriteLine("Wonderful!");
                    Console.ReadLine();
                    agenumfound = true;
                }

            }
            if (agenumfound == false)
            {
                Console.WriteLine("That is not an index. Please enter an appropriate answer");
                Console.ReadLine();

            }




            //Step 4.

            Console.WriteLine("Moving onto the third array.");
            Console.ReadLine();

            List<string> intList = new List<string>();
            intList.Add("Avery");
            intList.Add("Ingrid");
            intList.Add("Dahlia");
            

            Console.WriteLine(intList[0]);
            Console.WriteLine(intList[1]);
            Console.WriteLine(intList[2]);
            Console.ReadLine();

            Console.WriteLine("Please select a string from the list");
            string listarrayinput = Console.ReadLine();
            string listarrayInput = Convert.ToString(listarrayinput);

            Console.WriteLine("You selected " + (listarrayinput));
            Console.ReadLine();

            

            bool listarrayfound = false;
            for (int i = 0; i < intList.Count; i++) //For lists use "count" not "length".
            {
                if (listarrayInput == intList[i])
                {

                    Console.WriteLine("One of many good choices!");
                    Console.ReadLine();
                    listarrayfound = true;
                }
            }
            if (listarrayfound == false)
            {
                Console.WriteLine("I didn't realize you has that sort of taste in names...");
                Console.ReadLine();
                Console.WriteLine("Please try another");
                Console.ReadLine();
            }
            
        }
    }
}
