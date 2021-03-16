#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            //Month first = Month.December;
            //Console.WriteLine(first);
            //first++;
            //Console.WriteLine(first);
           //Date now;
            //Date defaultDate = new Date();
            //Console.WriteLine(defaultDate);
            Date weddingAnniversary = new Date(2015, Month.July, 4);
            Console.WriteLine($"Value of weddingAnniversary is {weddingAnniversary}");
            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy weddingAnniversary is {weddingAnniversaryCopy}");
            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"Value of weddingAnniversaryCopy is still {weddingAnniversaryCopy}");
            //Date copy = now;
            //Console.WriteLine(copy);
            //weddingAnniversary.AdvanceMonth();
            //Console.WriteLine(weddingAnniversary);
            int[] box;
            box = new int[4] { 1, 2, 3, 257 };
            int[] box1 = { 4, 3, 2, 1 };
            int[] varArr = new int[] { 1, 2, 3, 4 };
            
            int[] test = { 1, 2, 3, 264 };

            //for (int i = 0; i < test.Length; i++)
            //{
            //    Console.WriteLine(test[i]); 
            //}
            //foreach(int q in test)
            //{
            //    Console.WriteLine(q);
            //}

            var unnameClasses = new[] { new {firstName = "Petja", Age = 20},
                                        new {firstName = "Vasja", Age = 30},
                                        new {firstName = "Roman", Age = 15} };
            foreach(var unname in unnameClasses)
            {
                Console.WriteLine($"First Name : {unname.firstName} Age : {unname.Age}");
            }

            int[] fillArray()
            {
                Console.Write("Entry size of array : ");
                string reply = Console.ReadLine();
                int size = int.Parse(reply);
                int[] arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Entry {i} item : ");
                    reply = Console.ReadLine();
                    arr[i] = int.Parse(reply);
                }
                Console.WriteLine("Array is full!");
                return arr;
            }
            int[] tester = fillArray();
            foreach (int item in tester)
            {
                Console.WriteLine(item);
            }
           

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
