using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double fee = calculateFee(theDailyRate: 450);
            Console.WriteLine($"Fee = {fee}");
        }

        
        double calculateFee(double theDailyRate = 500, int noOfDays = 1)
        {
           Console.WriteLine("calculateFee using tow optional parameters");
           return theDailyRate * noOfDays;
        }
        double calculateFee(double dailyRate = 500)
        {
           Console.WriteLine("calculateFee using one optional parameter");
           int defaultNoOfDays = 1;
           return defaultNoOfDays * dailyRate;
        }
        double calculateFee()
        {
           Console.WriteLine("calculateFee using hardcoded value");
           int defaultNoOfDays = 1;
           double defaultDailyRate = 400;
           return defaultNoOfDays * defaultDailyRate;
        }


    }
}
