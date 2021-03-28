using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ages = new SortedList<string, int>();

            ages.Add("Belmando", 50);
            ages.Add("JekiChan", 31);

            ages["Dolf"] = 60;
            ages["Vandam"] = 45;

            Console.WriteLine("SortedList contain :");
            foreach (KeyValuePair<string, int> element in ages)
            {
                int age = element.Value;
                string name = element.Key;

                Console.WriteLine($"{name} is {age}");
            }
        }
    }
}
