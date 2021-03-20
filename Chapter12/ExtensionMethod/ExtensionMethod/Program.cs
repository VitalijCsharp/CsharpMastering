using System;
using Extensions;

namespace ExtensionMethod
{
    class Program
    {
        static void doWork()
        {
            //int temp = 9;
            //Console.WriteLine(temp.ConvertToBase(8));

            int x = 597;
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{x} in base {i} = {x.ConvertToBase(i)}");
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
