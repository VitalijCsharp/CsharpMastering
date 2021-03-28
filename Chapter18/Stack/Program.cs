using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            Console.WriteLine("Pushing items onto the Sack");
            foreach (var number in new int[] {1,2,3,4,5})
            {
                numbers.Push(number);
                Console.WriteLine($"{number} has been pushing on the stack");
            }

            Console.WriteLine("\nThe stack now contains");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPoping item from the stack");
            while (numbers.Count > 0)
            {
                int number = numbers.Pop();
                Console.WriteLine($"{number} has been popped off the stack");
            }
        }
    }
}
