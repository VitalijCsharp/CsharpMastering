using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Globalization;

namespace PLINQ
{
    class Program
    {
        public const int NUM = int.MaxValue / 1000;

        static void Main(string[] args)
        {
            //Test1();
             Test2();
        }

        public static void Test1()
        {
            Console.WriteLine("\nTest 1");

            int[] numbers = new int[NUM];
            Random random = new Random(999);

            for (int i = 0; i < NUM; i++)
            {
                numbers[i] = random.Next(200);
            }

            // TO DO: Create a LINQ query that retrieves all numbers that are greater than 100
            //var greater100 = numbers.Where(i => i > 100).Select(j => j);
            //List<int> conteiner = new List<int>();
            var over100 = from i in numbers.AsParallel()
                          where TestIfTrue(i > 100)
                          select i;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            //foreach (var item in greater100)
            //{
            //    conteiner.Add(item);
            //}
            // TO DO: Run the LINQ query and save the results in a List<int> object
            List<int> numberOver100 = new List<int>(over100);

            long milliseconds = timer.ElapsedMilliseconds;
            timer.Stop();

            //foreach (var item in conteiner)
            //{
            //    Console.Write($"{item} ");
            //}
            // TO DO: Display the results
            Console.WriteLine($"Numbers count {numberOver100.Count}");
            Console.WriteLine($"Time taken was {milliseconds} ms");
        }

        public static bool TestIfTrue(bool expr)
        {
            Thread.SpinWait(1000);
            return expr;
        }

        public static void Test2()
        {
            Console.WriteLine("\nTest 2");

            try
            {
                // TO DO: Create a LINQ query that retrieves customers and orders from arrays
                // Store each row returned in an OrderInfo object
                //my version
                //var EOI = CustomersInMemory.Customers.Select(cust => new { cid = (cust.Split(','))[0], company = (cust.Split(','))[1]}).
                //                            Join(OrdersInMemory.Orders.Select(order => new { cid = order.Split(',')[1], orderID = order.Split(',')[0], date = order.Split(',')[2]}), cust => cust.cid, order => order.cid, 
                //                            (cust, order) => new OrderInfo { CustomerID = cust.cid, CompanyName = cust.company, OrderDate = DateTime.Parse(order.date), OrderID = int.Parse(order.orderID) });                

                //from book
                var OrderInfoQuery = from c in CustomersInMemory.Customers.AsParallel()
                                     join o in OrdersInMemory.Orders.AsParallel()
                                     on c.Split(',')[0] equals o.Split(',')[1]
                                     select new OrderInfo
                                     {
                                         CompanyName = c.Split(',')[1],
                                         CustomerID = c.Split(',')[0],
                                         OrderID = Convert.ToInt32(o.Split(',')[0]),
                                         OrderDate = Convert.ToDateTime(o.Split(',')[2], new CultureInfo("en-Us"))
                                     };

                Stopwatch timer = new Stopwatch();
                timer.Start();

                // TO DO: Run the LINQ query and save the results in a List<OrderInfo> object
                //my version
                //List<OrderInfo> LOI = new List<OrderInfo>(EOI);

                //from book
                List<OrderInfo> orderInfo = new List<OrderInfo>(OrderInfoQuery);

                long milliseconds = timer.ElapsedMilliseconds;
                timer.Stop();

                //my version
                //foreach (var item in LOI)
                //{
                //    Console.WriteLine($"Cust Id: {item.CustomerID}, Company: {item.CompanyName}, Order ID: {item.OrderID}, Date: {item.OrderDate.ToString()}");
                //}

                //from book
                Console.WriteLine($"There are {orderInfo.Count} orders");
                // TO DO: Display the results

                Console.WriteLine($"Time taken for joining two arrays in memory: {milliseconds} ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
