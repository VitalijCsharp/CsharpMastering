using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Mathematic
    {
        public static int Sum(params int[] par)
        {
            int sum = 0;
            foreach (var operand in par)
            {
                sum += operand;
            }
            return sum;
        }
    }
   
    
}
