using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace CalculatePI
{
    class Program
    {
        // Tuning constants:
        // If you have lots of memory, increase NUMPOINTS to improve the accuracy
        private const int NUMPOINTS = 10000000;
        private const int RADIUS = 1000000;

        // Value to seed the random number generator for each calculation.
        // Using the same seed value ensures that the same results should be generated each time
        private const int SEED = 269222;

        // If you have a very fast processor, increase SPINWAITS to show the effects of parallelization
        private const int SPINWAITS = 1000;

        private static double SerialPI()
        {
            List<double> pointsList = new List<double>();
            Random random = new Random(SEED);
            int numPointsInCircle = 0;
            Stopwatch timer = new Stopwatch();
            timer.Start();

            try
            {
                // TO DO: Implement the geometric approximation of PI
                //my version
                //for (int i = 0; i < NUMPOINTS; i++)
                //{                    
                //    double y = random.Next() % RADIUS;
                //    double x = random.Next() % RADIUS;
                //    double dist = Math.Sqrt(y * y + x * x);
                //    if(dist < RADIUS)
                //    {
                //        pointsList.Add(dist);
                //        numPointsInCircle++;
                //    }
                //}
                //double num = NUMPOINTS;
                //double pi = 4 * pointsList.Count / num;
                //return pi;

                //from book
                for (int i = 0; i < NUMPOINTS; i++)
                {
                    double xCoord = random.Next(RADIUS);
                    double yCoord = random.Next(RADIUS);
                    double distanceFromOrigin = Math.Sqrt(xCoord * xCoord + yCoord * yCoord);
                    pointsList.Add(distanceFromOrigin);
                    doAdditionalProcessing();
                }

                foreach (var item in pointsList)
                {
                    if(item <= RADIUS)
                    {
                        numPointsInCircle++;
                    }
                }

                return 4 * (double)numPointsInCircle / (double)pointsList.Count;
            }
            finally
            {
                long milliseconds = timer.ElapsedMilliseconds;
                Console.WriteLine($"SerialPI complete: Duration: {milliseconds} ms");
                Console.WriteLine($"Points in pointsList: {pointsList.Count}. Points within circle: {numPointsInCircle}");
            }
        }

        private static double ParallelPI()
        {
            ConcurrentBag<double> pointsList = new ConcurrentBag<double>();
            Random random = new Random(SEED);
            int numPointsInCircle = 0;
            Stopwatch timer = new Stopwatch();
            timer.Start();

            try
            {
                // TO DO: Implement the geometric approximation of PI
                Parallel.For(0, NUMPOINTS, (x) =>
                {
                    double xCoord;
                    double yCoord;
                    lock (pointsList)
                    {
                        xCoord = random.Next(RADIUS);
                        yCoord = random.Next(RADIUS);
                    }
                    double distanceFromOrigin = Math.Sqrt(xCoord * xCoord + yCoord * yCoord);
                    pointsList.Add(distanceFromOrigin);
                    doAdditionalProcessing();
                });

                foreach (var item in pointsList)
                {
                    if (item <= RADIUS)
                    {
                        numPointsInCircle++;
                    }
                }
                return 4 * (double)numPointsInCircle / (double)pointsList.Count;
            }
            finally
            {
                long milliseconds = timer.ElapsedMilliseconds;
                Console.WriteLine($"ParallelPI complete: Duration: {milliseconds} ms");
                Console.WriteLine($"Points in pointsList: {pointsList.Count}. Points within circle: {numPointsInCircle}");
            }
            
        }

        private static void doAdditionalProcessing()
        {
            Thread.SpinWait(SPINWAITS);
        }

        static void Main(string[] args)
        {
            double pi = SerialPI();
            Console.WriteLine("Geometric approximation of PI calculated serially: {0}", pi);

            Console.WriteLine();

            pi = ParallelPI();
            Console.WriteLine("Geometric approximation of PI calculated in parallel: {0}", pi);
        }
    }
}
