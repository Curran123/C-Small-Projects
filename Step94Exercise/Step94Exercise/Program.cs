﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step94Exercise
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Guess what color I'm thinking of.");
            string guess = Convert.ToString(Console.ReadLine());
            bool GuessedColor = guess == "cyan";

            bool oneofthreecolors = guess == "purple";

            while (!oneofthreecolors);
            switch (guess)
                {
                    case "purple":
                        Console.WriteLine("Why would you even suggest that color? Please try again.");
                        Console.WriteLine("Guess a color.");
                        guess = Convert.ToString(Console.ReadLine());
                        break;
                }


            do //execute no matter what at least once
            {
                switch (guess)
                {
                    case "red":
                        Console.WriteLine("You guessed red. Please try again.");
                        Console.WriteLine("Guess a color.");
                        guess = Convert.ToString(Console.ReadLine());
                        break;

                    case "green":
                        Console.WriteLine("You guessed green. Please try again.");
                        Console.WriteLine("Guess a color.");
                        guess = Convert.ToString(Console.ReadLine());
                        break;

                    case "yellow":
                        Console.WriteLine("You guessed yellow. Please try again.");
                        Console.WriteLine("Guess a color");
                        guess = Convert.ToString(Console.ReadLine());
                        break;

                    case "orange":
                        Console.WriteLine("You guessed orange. Please try again.");
                        Console.WriteLine("Guess a color.");
                        guess = Convert.ToString(Console.ReadLine());
                        break;

                    case "cyan":
                        Console.WriteLine("You are correct!");
                        GuessedColor = true;
                        break;

                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess a color.");
                        guess = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            while (!GuessedColor); //execute while that which is in the parentheses is true, and then go back to "do" only if the condition is true
                
                    Console.Read();
                

            
        }
    }
}
            
        
    

            
    



           

        
    

