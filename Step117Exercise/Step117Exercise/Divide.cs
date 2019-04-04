using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step117Exercise
{
    public class Divide
    {

        

        public int DivideMethod(int num1)//"...the data passed to it" meaning calling a value from the Main method.
        {
            int quotient;
            
            quotient = num1 / 2;
            return quotient;

        }
        public void Game(string num1, out string gamename, out string gamerating)//only need "out" when creating the method.
        {
            string guess;
            guess = num1;
            gamename = "Total War: Shogun 2";
            gamerating = "T";
            
            

            
        }
        public double DivideMethod(double num2)
        {
            double product;

            product = 5.5 + num2;
            return product;
        }
        




    }
    static class Multiply
    {
        

    }
}
