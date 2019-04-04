using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step114Exercise
{
    public class Math
    {
        public int MathMethod(int num1)//num 1 is the user's input; "r" is being passed to the parameter num1.
        {


            int sum;
            
            sum = 12 + num1;
            return sum;

        }
        public double MathMethod(double num2)
        {
            double sum;
            
            sum = 0.0 + num2;
            return sum;

        }
        //take string and turn into an int
    
        public string MathMethod(string num3)
        {
            int sum;
            int Num3 = Convert.ToInt32(num3);
            
            sum = 0 + Num3;
            string Sum = Convert.ToString(sum);
            return Sum;

        }

    }
}