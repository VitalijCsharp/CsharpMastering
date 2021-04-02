using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvetnsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EventGenerator EV = new EventGenerator();
            SubscriberEvent0 s0 = new SubscriberEvent0();
            SubscriberEvent1 s1 = new SubscriberEvent1();

            EV.MyEvent += s0.SendMessage;
            EV.MyEvent += s1.SendMessage;

            EV.DoSomething();
        }
    }
}
