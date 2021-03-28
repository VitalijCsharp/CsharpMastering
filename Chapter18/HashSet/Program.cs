using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> employees = new HashSet<string>(new string[] { "Fred", "Bert", "Harry", "John" });
            HashSet<string> customers = new HashSet<string>(new string[] { "John", "Sid", "Harry", "Dian" });

            employees.Add("James");
            customers.Add("Francesca");

            Console.WriteLine("Employees :");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("\nCustomers :");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("\nCustomer who are also employees :");
            customers.IntersectWith(employees);

            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
