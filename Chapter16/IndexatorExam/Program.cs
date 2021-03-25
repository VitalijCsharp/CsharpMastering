using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int adapted = 4;
            int pos = 1;         
            IntBits tmp = new IntBits(adapted);

            Console.WriteLine($"In {pos} position is {tmp[pos]} of number {adapted}");
            tmp[pos] = true;
            Console.WriteLine($"Set {pos} to 1 we get number {tmp.Bytes}");
        }
    }
}
