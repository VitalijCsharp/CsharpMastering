using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace QueryBinaryTree
{
    class Program
    {
        static void doWork()
        {
            Tree<Employee> empTree = new Tree<Employee>(
                new Employee 
                {   
                    Id = 1, 
                    FirstName = "Kim", 
                    LastName = "Abercrombie",
                    Department = "IT"
                }
            );
            empTree.Insert(new Employee
            {
                Id = 2,
                FirstName = "Jeff",
                LastName = "Hay",
                Department = "Marketing"
            });
            empTree.Insert(new Employee
            {
                Id = 4,
                FirstName = "Charlie",
                LastName = "Herb",
                Department = "IT"
            });
            empTree.Insert(new Employee
            {
                Id = 6,
                FirstName = "Chris",
                LastName = "Preston",
                Department = "Sales"
            });
            empTree.Insert(new Employee
            {
                Id = 3,
                FirstName = "Dave",
                LastName = "Barnett",
                Department = "Sales"
            });
            empTree.Insert(new Employee
            {
                Id = 5,
                FirstName = "Tim",
                LastName = "Litton",
                Department = "Marketing"
            });

            Console.WriteLine("All employees:");
            var allEmployees = from e in empTree.ToList<Employee>()
                            select e;

            foreach (var item in allEmployees)
            {
                Console.WriteLine(item);
            }

            empTree.Insert(new Employee
            {
                Id = 7,
                FirstName = "Vitalij",
                LastName = "Kolodka",
                Department = "IT"
            });

            Console.WriteLine("\nAll employees after inserting:");
            foreach (var item in allEmployees)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("List of Departments: ");

            ////var departments = empTree.Select(d => d.Department).Distinct();
            //var departments = (from d in empTree
            //                  select d.Department).Distinct();
            //foreach (var item in departments)
            //{
            //    Console.WriteLine($"Department: {item}");
            //}

            //Console.WriteLine("\nEmployees in the IT department: ");
            ////var itEmp = empTree.Where(emp => String.Equals(emp.Department, "IT"))
            ////                   .Select(emp => emp);
            //var itEmp = from it in empTree
            //            where String.Equals(it.Department, "IT")
            //            select it;
            //foreach (var it in itEmp)
            //{
            //    Console.WriteLine(it);
            //}

            //Console.WriteLine("\nEmployees grouped by department: ");
            ////var GroupsDeps = empTree.GroupBy(emp => emp.Department);
            //var GroupsDeps = from g in empTree
            //                 group g by g.Department;
            //foreach (var Deps in GroupsDeps)
            //{
            //    Console.WriteLine($"In Department {Deps.Key} {Deps.Count()} employees:");
            //    foreach (var dep in Deps)
            //    {
            //        //Console.WriteLine(dep);
            //        Console.WriteLine($"\t{dep.FirstName} {dep.LastName}");
            //    }
            //}
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
