using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            // TODO:
            //Point origin = new Point(56, 78);

            //Console.WriteLine($" X = {origin.x} and Y = {origin.y}");
            Point origin = new Point();
            Point origin1 = new Point();
            Point bottomRight = new Point();
            Point topLeft = new Point(1366, 768);
            //Point.DistanceTo(new Point(2, 2));
            Console.WriteLine($"Counter = {Point.GetCounter()}");
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
