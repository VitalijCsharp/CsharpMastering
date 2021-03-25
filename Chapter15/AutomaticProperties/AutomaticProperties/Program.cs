using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    class Program
    {
        static void doWork()
        {
            Polygon square = new Polygon();
            Polygon triangle = new Polygon { NumSides = 3 };
            Polygon pentagon = new Polygon { NumSides = 5, SideLength = 15.5 };

            Console.WriteLine($"Square: number of side is {square.NumSides}, length of each side is {square.SideLength}");
            Console.WriteLine($"Triangle: number of side is {triangle.NumSides}, length of each side is {triangle.SideLength}");
            Console.WriteLine($"Pentagon: number of side is {pentagon.NumSides}, length of each side is {pentagon.SideLength}");
        }

        static void Main(string[] args)
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
