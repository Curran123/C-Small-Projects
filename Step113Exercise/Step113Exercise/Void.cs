using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step113Exercise
{
    public class Void
    {
        public int VoidMethod(out int num1, int num2)
        {
            int result;
            num1 = 8;
            num2 = 5;
            result = 2 * num1;
            return num2;
        }
    }
}
