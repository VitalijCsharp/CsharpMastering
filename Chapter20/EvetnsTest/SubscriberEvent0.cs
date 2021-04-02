using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvetnsTest
{
    class SubscriberEvent0
    {
        private int myData = 0;

        public int MyData { get => myData; set => myData = value; }

        public void SendMessage(string str)
        {
            Console.WriteLine($"Subscriber {this.myData} {str} \n");
        }
    }
}
