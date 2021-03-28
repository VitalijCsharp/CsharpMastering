using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            //LinkedList<int> numbers = new LinkedList<int>() { 1, 2, 3, 4 }; dose not work. Work only with method .Add in collection

            foreach (var number in new int[] { 1, 2, 3, 4 })
            {
                numbers.AddFirst(number);
            }

            Console.WriteLine("Iterating linkedList by for to forward: ");
            for (LinkedListNode<int> node = numbers.First; node != null; node = node.Next)
            {
                int value = node.Value;
                Console.WriteLine(value);
            }

            Console.WriteLine("Iterating linkedList by for to backward: ");
            for (LinkedListNode<int> node = numbers.Last; node != null; node = node.Previous)
            {
                int value = node.Value;
                Console.WriteLine(value);
            }

            Console.WriteLine("Iterating linkedList by foreach :");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
