using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueBasedArray
{
    class Queue
    {
        private int SIZEQUEUE = 100;
        private object[] queue;
        private int tail = 0, head = 0;
        private int numbItem = 0;

        public Queue()
        {
            queue = new object[SIZEQUEUE];
        }
        public Queue(int size)
        {
            if (size > 0)
            {
                queue = new object[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Size must be greater than 0");
            }
        }

        public void Enqueue(object item)
        {
            if(numbItem == queue.Length)
            {
                Console.WriteLine("Queue is full!");
                throw new Exception("Queue is full!");
            }

            queue[head] = item;
            head++;
            head %= queue.Length;
            numbItem++;
        }

        public object Dequeue()
        {
            if(numbItem == 0)
            {
                Console.WriteLine("Queue is empty!");
                throw new Exception("Queue is empty!");
            }

            object result = queue[tail++];
            tail %= queue.Length;
            numbItem--;
            return result;
        }

        public bool IsQueueEmpty() => numbItem == 0;
       
    }
}
