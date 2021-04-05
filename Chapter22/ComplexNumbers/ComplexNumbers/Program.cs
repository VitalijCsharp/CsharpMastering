using System;

namespace ComplexNumbers
{
    class Program
    {
        static void doWork()
        {
            Complex first = new Complex(10, 4);
            Complex second = new Complex(5, 2);

            Console.WriteLine($"first is \t{first}");
            Console.WriteLine($"second is \t{second}");

            Complex temp = first + second;
            Console.WriteLine($"\nAdd : \t\t{temp}");

            temp = first - second;
            Console.WriteLine($"Substract : \t{temp}");

            temp = first * second;
            Console.WriteLine($"Multiply : \t{temp}");

            temp = first / second;
            Console.WriteLine($"Divide : \t{temp}");

            Console.WriteLine($"\nCurrent value of temp is {temp}");
            if(temp == 2)
            {
                Console.WriteLine("Comparison after conversion: temp == 2");
            }
            else
            {
                Console.WriteLine("Comparison after conversion: temp != 2");
            }

            temp += 2;
            Console.WriteLine($"Value after adding 2: temp = {temp}");

            int intTemp = (int)temp;
            Console.WriteLine($"\nInt value after conversation: intTemp = {intTemp}");
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
