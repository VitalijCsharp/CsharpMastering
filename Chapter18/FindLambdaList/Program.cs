using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLambdaList
{
    struct Person
    {
        public string name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Personall = new List<Person>()
            {
                new Person(){name = "Diana", ID = 1, Age = 23},
                new Person(){name = "Valentin", ID = 2, Age = 24},
                new Person(){name = "Petya", ID = 3, Age = 30}
            };

            //Person match = Personall.Find((Person p) => { return p.ID == 3;});
            Person match = Personall.Find(p => p.ID == 3);

            Console.WriteLine($"name = {match.name} \nID = {match.ID}\nAge = {match.Age}");

        }
    }
}
