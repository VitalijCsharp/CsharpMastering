using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Util
    {
        public static int UtilSum(params int[] paramlist)
        {
            Console.WriteLine("Using parametr list");
            if (paramlist == null)
            {
                throw new ArgumentException("UtilSum : null parameter list");
            }
            if (paramlist.Length == 0)
            {
                throw new ArgumentException("UtilSum : empty parameter list");
            }
            int sumTotal = 0;
            foreach (var operand in paramlist)
            {
                sumTotal += operand;
            }

            return sumTotal;
        }
        public static int UtilSum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using optional parameters");
            int sumTotal = param1 + param2 + param3 + param4;

            return sumTotal;
        }
    }
}
