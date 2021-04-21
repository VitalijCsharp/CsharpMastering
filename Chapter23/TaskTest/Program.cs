using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }
        private void test()
        {
            Task task = new Task(doWork);
            task.Start();
            Task newTask = task.ContinueWith(doNextWork, TaskContinuationOptions.OnlyOnFaulted);
        }
        private void doWork()
        {
            Console.WriteLine("doWork");
        }
        private void doNextWork(Task task)
        {
            Console.WriteLine("doNextWork");
        }
    }
    
}
