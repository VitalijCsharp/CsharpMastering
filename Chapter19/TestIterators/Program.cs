using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIterators
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCollection<string> bc = new BasicCollection<string>();

            bc.Fill("Hello", "hi", "Oloha", "Privet", "Zdarov");

            foreach (var item in bc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nRevers :");
            foreach (var item in bc.Revers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
