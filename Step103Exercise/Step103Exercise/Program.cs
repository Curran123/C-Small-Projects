using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step103Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //STEP 1-5.
            //Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array, adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line.
            //Create an infinite loop.
            //Fix the infinite loop so it will execute.
            //Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            //Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            string[] artists = new string[4];
            artists[0] = "Monty Oum";
            artists[1] = "Les Edwards";
            artists[2] = "John Blanche";
            artists[3] = "Peach Pit";
            Console.WriteLine("Monty Oum");
            Console.WriteLine("Les Edwards");
            Console.WriteLine("John Blanche");
            Console.WriteLine("Peach Pit");

            Console.WriteLine("Please state something that they all have in common");
            string artistarrayinput = Console.ReadLine();

            for (int a = 0; a < artists.Length; a++)
            {
                artists[a] = artists[a] + artistarrayinput; //"I want artists at any given index to become artists at that index plus the user's string."

            }
            for (int i = 0; i < artists.Length; i++) //Prints out the array.
            {
                Console.WriteLine(artists[i]); // What causes the array to loop through and print for each string.

            }
            
            Console.ReadLine();


            //Created an infinite loop with a "for" loop and a bool.
            bool art = true;
            while (art == true)
            {
                Console.WriteLine("Hello");
                art = false;

            }
            int artform = 10;
            while (artform < 20)
            {
                Console.WriteLine(artform);
                artform++;
            }
            artform = 10;
            while (artform <= 20)
            {
                Console.WriteLine(artform);
                artform++; //The only difference between the top loop and this one is that this one will print 20.
            }





            //STEP 6-8
            //Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 
            //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            //Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //Add code to that above loop that stops it from executing once a match has been found.

            List<string> DevolverDigitalList = new List<string>();
            DevolverDigitalList.Add("Hotline Miami");
            DevolverDigitalList.Add("Shadow Warrior");
            DevolverDigitalList.Add("Gods Will Be Watching");
            DevolverDigitalList.Add("Hatoful Boyfriend");
            DevolverDigitalList.Add("Bro force");
            DevolverDigitalList.Add("Enter the Gungeon");
            DevolverDigitalList.Add("Mother Russia Bleeds");

            Console.WriteLine("Please search for your preferred title from Devolver Digital");
            string x = Console.ReadLine();

            bool found = false;
            foreach (string s in DevolverDigitalList) //For each thing "s" in my list, do stuff.
            {
                if(s == x)
                {
                    Console.WriteLine(s);
                    Console.WriteLine("You selected " + (s));
                    Console.WriteLine("The position of this object is " + DevolverDigitalList.IndexOf(s));
                    found = true;
                    
                }
            }
            if (found == false)
            {
                Console.WriteLine("No matches found");
            }
            Console.ReadLine();





            //STEP 9-10.
            //Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            //Add code to that above loop that tells a user if they put in text that isn’t in the List.

            List<string> UnitsList = new List<string>();
            UnitsList.Add("Infantry");
            UnitsList.Add("Cavalry");
            UnitsList.Add("Artillery");
            UnitsList.Add("Submersibles");
            UnitsList.Add("Aircraft");
            UnitsList.Add("Artillery");

            Console.WriteLine("Please search for your preferred unit");
            string y = Console.ReadLine();

            bool foundduplicate = false;
            foreach (string t in UnitsList)
            {
                if (y == UnitsList.)
                {
                    
                  
                   
                    Console.WriteLine(t);
                    Console.WriteLine("The repeat is " + (t));
                    Console.WriteLine("The positions of this unit are " + UnitsList.IndexOf(t));
                    foundduplicate = true;

                }
            }
            if (foundduplicate == false)
            {
                Console.WriteLine("No duplicates found");
            }
            Console.ReadLine();

        }
        
    }
}
