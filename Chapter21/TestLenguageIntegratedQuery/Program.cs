using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLenguageIntegratedQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new[]
            {
                new {CustomerID = 1, FirstName = "Kim",
                    LastName = "Abercrombie", CompanyName = "Alpine Ski House"},
                new {CustomerID = 2, FirstName = "Jeff",
                    LastName = "Hay", CompanyName = "Coho Winery"},
                new {CustomerID = 3, FirstName = "Charlie",
                    LastName = "Herb", CompanyName = "Alpine Ski House"},
                new {CustomerID = 4, FirstName = "Chris",
                    LastName = "Preston", CompanyName = "Trey Research"},
                new {CustomerID = 5, FirstName = "Dave",
                    LastName = "Barnett", CompanyName = "Wingtip Toys"},
                new {CustomerID = 6, FirstName = "Ann",
                    LastName = "Beebe", CompanyName = "Coho Winery"},
                new {CustomerID = 7, FirstName = "John",
                    LastName = "Kane", CompanyName = "Wingtip Toys"},
                new {CustomerID = 8, FirstName = "David",
                    LastName = "Simpson", CompanyName = "Trey Research"},
                new {CustomerID = 9, FirstName = "Greg",
                    LastName = "Chapman", CompanyName = "Wingtip Toys"},
                new {CustomerID = 10, FirstName = "Tim",
                    LastName = "Litton", CompanyName = "Wide World Importer"}
            };

            var addresses = new[]
            {
                new{CompanyName = "Alpine Ski House", City = "Berne",
                    Country = "Switzerland"},
                new{CompanyName = "Coho Winery", City = "San Francisco",
                    Country = "United States"},
                new{CompanyName = "Trey Research", City = "New York",
                    Country = "United States"},
                new{CompanyName = "Wingtip Toys", City = "London",
                    Country = "United Kingdom"},
                new{CompanyName = "Wide World Importer", City = "Tetbury",
                    Country = "United Kingdom"},
            };

            // Select Выбор


            //IEnumerable<string> customerFirsName = customers.Select(c => $" {c.FirstName} {c.LastName}");
            //foreach (var item in customerFirsName)
            //{
            //    Console.WriteLine(item);
            //}

            //using operators query like SQL
            //IEnumerable<string> customerFirstName = from c in customers
            //                                        select c.CompanyName;
            //foreach (var item in customerFirstName)
            //{
            //    Console.WriteLine(item);
            //}


            //IEnumerable<FullName> customerFirsName = customers.Select(c => new FullName { firstName = c.FirstName, lastName = c.LastName});
            //foreach (var item in customerFirsName)
            //{
            //    Console.WriteLine($"{item.firstName} {item.lastName}");
            //}

            //using operators query like SQL
            //var customersFullName = from c in customers
            //                                        select new { c.FirstName, c.LastName };
            //foreach (var item in customersFullName)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}


            //var customerFirsName = customers.Select(c => new { firstName = c.FirstName, lastName = c.LastName });
            //foreach (var item in customerFirsName)
            //{
            //    Console.WriteLine($"{item.firstName} {item.lastName}");
            //}

            //Where and Select Фильтрация данных

            //IEnumerable<string> usCompanyName = addresses.Where(adress => String.Equals(adress.Country, "United States")).Select(cn => cn.CompanyName);

            //foreach (var item in usCompanyName)
            //{
            //    Console.WriteLine(item);
            //}
            //using operators query like SQL
            //IEnumerable<string> usCompanyName = from addres in addresses
            //                                    where String.Equals(addres.Country, "United States")
            //                                    select addres.CompanyName;
            //foreach (var item in usCompanyName)
            //{
            //    Console.WriteLine(item);
            //}


            //OrderBy

            //IEnumerable<string> ordered = addresses.OrderBy(Cn => Cn.CompanyName).Select(cn => cn.CompanyName);

            //foreach (var item in ordered)
            //{
            //    Console.WriteLine(item);
            //}
            //using operators query like SQL
            //IEnumerable<string> ordered = from custom in customers
            //                              orderby custom.FirstName
            //                              select custom.FirstName;

            //foreach (var item in ordered)
            //{
            //    Console.WriteLine(item);
            //}

            //OrderByDescending

            //IEnumerable<string> orderedDes = addresses.OrderByDescending(Cn => Cn.CompanyName).Select(cn => cn.CompanyName);

            //foreach (var item in orderedDes)
            //{
            //    Console.WriteLine(item);
            //}

            //GroupBy

            //var GroupedByCountry = addresses.GroupBy(c => c.Country);

            //foreach (var companiesPerCountry in GroupedByCountry)
            //{
            //    Console.WriteLine(
            //        $"Country: {companiesPerCountry.Key}\t{companiesPerCountry.Count()} companies");
            //    foreach (var companies in companiesPerCountry)
            //    {
            //        Console.WriteLine($"\t{companies.CompanyName}");
            //    }
            //}

            //Count

            //int count = addresses.Select(c => c.CompanyName).Count();
            //Console.WriteLine($"Number of company: {count}");            

            //int countDis = addresses.Select(c => c.Country).Distinct().Count();
            //Console.WriteLine($"Number of company: {countDis}");

            //Joint

            //var jointAdressCustomer = customers.Select(c => new { c.FirstName, c.LastName, c.CompanyName })
            //    .Join(addresses, cust => cust.CompanyName, adress => adress.CompanyName, (cust, adress) => new { cust.FirstName, cust.LastName, adress.Country });

            //foreach (var item in jointAdressCustomer)
            //{
            //    Console.WriteLine(item);
            //}

            //using operators query like SQL

            var jointAdressCustomer = from cust in customers
                                      join adr in addresses
                                      on cust.CompanyName equals adr.CompanyName
                                      select new { cust.FirstName, cust.LastName, adr.City};

            foreach (var item in jointAdressCustomer)
            {
                Console.WriteLine(item);
            }
        }



    }
    class FullName
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
