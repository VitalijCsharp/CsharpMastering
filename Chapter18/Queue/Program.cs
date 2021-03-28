using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            Console.WriteLine("Populating the queue");
            foreach (var number in new int[] {1,2,3,4})
            {
                numbers.Enqueue(number);
                Console.WriteLine($"{number} has joined the queue");
            }
            Console.WriteLine("\nQueue contains following items");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDraining the queue");
            while(numbers.Count > 0)
            {
                int number = numbers.Dequeue();
                Console.WriteLine($"{number} leave the queue");
            }
        }
    }
}
