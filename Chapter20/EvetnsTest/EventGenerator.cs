using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvetnsTest
{
    class EventGenerator
    {
        public delegate void DelegateForEvent(string message);
        public event DelegateForEvent MyEvent;

        public void DoSomething()
        {
            foreach (var item in new string[] {"One", "Three", "Fore", "Five"})
            {
                Console.WriteLine(item);
            }
            //if(MyEvent != null)
            //{
            //    MyEvent("Event Invoked");
            //}
            MyEvent?.Invoke("Event Invoked");
        }
    }
}
