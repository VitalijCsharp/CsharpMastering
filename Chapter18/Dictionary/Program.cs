using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ages = new Dictionary<string, int>();

            ages.Add("Johnes", 100);
            ages.Add("Diana", 60);

            ages["Johnes"] = 23;
            ages["Diana"] = 31;

            Console.WriteLine("Dictionary contains :");
            foreach (KeyValuePair<string, int> element in ages)
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine($"{name} is {age}");
            }
        }
    }
}
