using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Calculator calc = new Calculator())
            {
                //Console.WriteLine($"120/0 = {calc.Divide(120, 0)}"); 
            }
            Console.WriteLine("Program finishing");

            AvtoGenDispose Avto = new AvtoGenDispose();
        }
    }
}
