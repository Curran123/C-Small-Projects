using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step111Exercise
{
    public class Multiply
    {
        //int l = Convert.ToInt32(Console.ReadLine());

        public int  MultiplyOne(int num1) //Method 1
        {
          
            int result;
            
            result = (num1 * 6);
            return result;
            
        }
        public int MultiplyTwo(int num2) //Method 2
        {
            
            int result;
            
            result = (num2 * 10);
            return result;
        }
        public int MultiplyThree(int num3) //Method 3
        {
           
            int result;
            
            result = (num3 * 4);
            return result;
        }
        

    }
}
