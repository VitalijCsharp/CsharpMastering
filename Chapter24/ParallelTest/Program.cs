using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTest
{
    class Program
    {
        public const int NUMELEMENT = 10;
        static void Main(string[] args)
        {
            //SerialTest();
            ParallelTest();
        }

        private static void SerialTest()
        {
            int[] data = new int[NUMELEMENT];
            int j = 0;

            for (int i = 0; i < NUMELEMENT; i++)
            {
                j = i;
                doAdditionalProcessing();
                data[i] = j;
                doAnotherProcessing();
            }

            for (int i = 0; i < NUMELEMENT; i++)
            {
                Console.WriteLine($"Element {i} has value {data[i]}");
            }
        }

        private static void ParallelTest()
        {
            int[] data = new int[NUMELEMENT];
            int j = 0;

            Parallel.For(0, NUMELEMENT, (i) =>
            {
                //int j = 0;
                j = i;
                doAdditionalProcessing();
                data[i] = j;
                doAnotherProcessing();
            });

            for (int i = 0; i < NUMELEMENT; i++)
            {
                Console.WriteLine($"Element {i} has value {data[i]}");
            }
        }

        private static void doAnotherProcessing()
        {
            Thread.Sleep(10);
        }

        private static void doAdditionalProcessing()
        {
            Thread.Sleep(10);
        }
    }
}
