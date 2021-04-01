using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate myEvent = null;
        public void InvokeEvent()
        {
            if(myEvent != null)
            {
                myEvent();
                //myEvent.Invoke();
            }
        }
    }
    class Program
    {
        static private void hendler1()
        {
            Console.WriteLine("Обработчик событий 1");
        }

        static private void hendler2()
        {
            Console.WriteLine("Обработчик событий 2");
        }
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.myEvent += new EventDelegate(hendler1);
            instance.myEvent += hendler2;
            instance.InvokeEvent();

            Console.WriteLine("-----------");

            instance.myEvent -= new EventDelegate(hendler2);

            instance.InvokeEvent();
        }
    }
}
