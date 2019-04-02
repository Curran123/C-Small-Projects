using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step113Exercise
{
    public class Void
    {
        public void VoidMethod(int num1, int num2) //void means nothing is returned.
        {
            int result;
            result = num1 * num2;
            Console.WriteLine(num2);
            Console.WriteLine(result);

            //"return" vs. "display"
            //return must use "return" keyword, whereas "display" means
            //you can use Console.WriteLine
        }
    }
}
