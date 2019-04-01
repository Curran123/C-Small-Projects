using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step111Exercise
{
    public class Multiply
    {
        int l = Convert.ToInt32(Console.ReadLine());
        public int  MultiplyOne(int num1) //Method 1
        {
          
            int result;
            num1 = 6;
            result = (num1 * l);
            return result;
            
        }
        public int MultiplyTwo(int num2) //Method 2
        {
            
            int result;
            num2 = 10;
            result = (num2 * l);
            return result;
        }
        public int MultiplyThree(int num3) //Method 3
        {
           
            int result;
            num3 = 4;
            result = (num3 * l);
            return result;
        }
        

    }
}
