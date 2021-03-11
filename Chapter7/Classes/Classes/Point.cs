#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        // TODO:
        private int x, y;
        private static int counter = 0;

        //public Point(int arg1, int arg2)
        //{
        //    x = arg1;
        //    y = arg2;
        //}

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            counter++;
            //Console.WriteLine($"x : {x}, y : {y}");
        }
        public Point()
        {
            this.x = -1;
            this.y = -1;
            counter++;
        }
        public static int GetCounter() => counter;
       
        public double DistanceTo(Point other)
        {
            //return  Math.Pow((Math.Pow(Math.Abs(other.x - x), 2) + Math.Pow(Math.Abs(other.y - y), 2)), 0.5);
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = System.Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
            return distance;
        }
    }
}
