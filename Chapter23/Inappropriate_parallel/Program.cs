using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Inappropriate_parallel
{
    class Program
    {
        private static int accomulator = 0;
        static void Main(string[] args)
        {
            //for (int i = 0; i < 100; i++)
            //{
            Parallel.For(0, 100, AddToAccomulator);
                //AddToAccomulator(i);
            //}
            Console.WriteLine($"Accomulator = {accomulator}");
        }

        private static void AddToAccomulator(int x)
        {
            if((accomulator % 2) == 0)
            {
                accomulator += x;
                Thread.Sleep(10);
            }
            else
            {
                accomulator -= x;
            }
        }
    }
}
