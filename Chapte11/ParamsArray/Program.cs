using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //int[] param = new int[0];
            // Console.WriteLine(Util.UtilSum(13,23,45,3,4,6,7,3,987,64,4));
            Console.WriteLine(Util.UtilSum(2,4,6,8,10));
            //int numPar;
            //int[] operands;
            //Console.WriteLine("If you want sum enter number less than 6 or 6 if go out.");
            //do
            //{
            //    Console.Write("Choose number of parameters : ");
            //    numPar = int.Parse(Console.ReadLine());
            //    switch (numPar)
            //    {
            //        case 1:
            //            operands = new int[1];
            //            fillArray(operands);
            //            Console.WriteLine($"Sum = {Mathematic.Sum(operands[0])}");
            //            break;
            //        case 2:
            //            operands = new int[2];
            //            fillArray(operands);
            //            Console.WriteLine($"Sum = {Mathematic.Sum(operands[0], operands[1])}");
            //            break;
            //        case 3:
            //            operands = new int[3];
            //            fillArray(operands);
            //            Console.WriteLine($"Sum = {Mathematic.Sum(operands[0], operands[1], operands[2])}");
            //            break;
            //        case 4:
            //            operands = new int[4];
            //            fillArray(operands);
            //            Console.WriteLine($"Sum = {Mathematic.Sum(operands)}");
            //            break;
            //        case 5:
            //            operands = new int[5];
            //            fillArray(operands);
            //            Console.WriteLine($"Sum = {Mathematic.Sum(operands)}");
            //            break;

            //        default:
            //            Console.WriteLine("Enter number less or equal than 6");
            //            break;
            //    } 
            //} while (numPar < 6);

            void fillArray(int[] ar)
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    Console.Write($"Enter {i} param : ");
                    ar[i] = int.Parse(Console.ReadLine());
                }
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
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
