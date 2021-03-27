using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueBasedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Queue que = new Queue(3);

                que.Enqueue(1);
                que.Enqueue(2);
                que.Enqueue(3);
                //que.Enqueue(4);

                do
                {
                    Console.WriteLine(que.Dequeue());
                } while (false);

                que.Enqueue(24);

                while (!que.IsQueueEmpty())
                {
                    Console.WriteLine(que.Dequeue());
                }
            }
            catch (Exception ex)
            {

               Console.WriteLine(ex.Message);
            }


        }
    }
}
