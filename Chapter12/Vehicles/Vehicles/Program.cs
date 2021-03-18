using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane :");
            Airplane myAirplan = new Airplane();
            myAirplan.StartEngine("br-br-br");
            myAirplan.TakeOff();
            myAirplan.Drive();
            myAirplan.Land();
            myAirplan.StopEngine("frfrfrfrfrfr");

            Console.WriteLine("\nJourney by car :");
            Car myCar = new Car();
            myCar.StartEngine("jin-jin-jin");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("stop-stop-stop");

            Console.WriteLine("\nTesting polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myAirplan;
            v.Drive();
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
