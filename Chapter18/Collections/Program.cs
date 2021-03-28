using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        /// <summary>
        ///List
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>() { 10, 9, 8, 7, 7, 6, 5, 10, 4, 3, 2, 1 };

            //foreach (var item in new int[12]{ 10 , 9 , 8 , 7 , 7 , 6 , 5 , 10 , 4 , 3 , 2 , 1})
            //{
            //    numbers.Add(item);
            //}

            //for (int i = 0; i < 12; i++) assigned to list by index like array
            //{
            //    numbers[i] = 1;
            //}
            numbers.Insert(numbers.Count - 1, 99);

            numbers.Remove(3);

            numbers.RemoveAt(6);

           

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                Console.WriteLine(number);
            }

            Console.WriteLine("\n Iterating using foreach statement:");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
