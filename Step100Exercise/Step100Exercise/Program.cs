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
            //STEP 1.

            string[] gamegenres = new string[4];
            gamegenres[0] = "JRPG";
            gamegenres[1] = "Turn-based strategy";
            gamegenres[2] = "RTS";
            gamegenres[3] = "FPS";
            Console.WriteLine(0);
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            

            Console.WriteLine("Please select an index from the array 0-3");
            string gamearrayinput = Console.ReadLine();
            int gamearrayInput = Convert.ToInt32(gamearrayinput);
            if (gamearrayInput < 0 || gamearrayInput > 3)
            {
                Console.WriteLine("That is incorrect. Please select another number.");
                gamearrayinput = Console.ReadLine();
                gamearrayInput = Convert.ToInt32(gamearrayinput);
            }


            //Trying to establish a variable analogous to "i" below. 
            bool selection = false;
            for (int m = 0; m <= gamegenres.Length-1; m++)
            {
                if (gamegenres[gamearrayInput] == gamegenres[m])
                {
                    Console.WriteLine("You selected " + gamegenres[m]);
                    Console.ReadLine();
                    Console.WriteLine("Great");
                    Console.ReadLine();
                    selection = true;
                }

            }



            //STEP 2.

            Console.WriteLine("Moving onto the second array.");
            Console.ReadLine();

            int[] agenumArray = new int[4];
            agenumArray[0] = 6;
            agenumArray[1] = 9;
            agenumArray[2] = 15;
            agenumArray[3] = 18;

            Console.WriteLine(0);
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);


            //alternate way
            //int[] agenumArray = new int[] { 6, 9, 15, 18 };

            Console.WriteLine("Please select an index from the array"); //Need to convert agearrayinput from a string to an integer.
            string agearrayinput = Console.ReadLine();
            int agearrayInput = Convert.ToInt32(agearrayinput);
            if (agearrayInput < 0 || agearrayInput > 3)
            {
                Console.WriteLine("That is incorrect. Please select another number.");
                agearrayinput = Console.ReadLine();
                agearrayInput = Convert.ToInt32(agearrayinput);
            }

            bool choice = false;
            for (int j = 0; j <= gamegenres.Length-1; j++)
            {
                if (agenumArray[agearrayInput] == agenumArray[j])
                {
                    Console.WriteLine("You selected " + agenumArray[j]);
                    Console.ReadLine();
                    Console.WriteLine("Wonderful");
                    Console.ReadLine();
                    choice = true;
                }
                
            }
            


            //STEP 4.

            Console.WriteLine("Moving onto the third array.");
            Console.ReadLine();

            List<string> intList = new List<string>();
            intList.Add("Avery");
            intList.Add("Ingrid");
            intList.Add("Dahlia");
            
            Console.WriteLine(0);
            Console.WriteLine(1);
            Console.WriteLine(2);
           
            Console.WriteLine("Please select a string from the list");
            string listarrayinput = Console.ReadLine();
            int listarrayInput = Convert.ToInt32(listarrayinput);
            if (listarrayInput < 0 || agearrayInput > 3)
            {
                Console.WriteLine("I didn't realize you had that sort of taste in names.");
                listarrayinput = Console.ReadLine();
                listarrayInput = Convert.ToInt32(listarrayinput);
            }

            bool decision = false;
            for (int r = 0; r <= intList.Count-1; r++)
            {
                if (intList[listarrayInput] == intList[r]); 
                {
                    Console.WriteLine("You selected " + intList[r]);
                    Console.ReadLine();
                    Console.WriteLine("One of many fine choices!");
                    Console.ReadLine();
                    decision = true;
                    Environment.Exit(0);
                }

            }



           
        }
    }
}