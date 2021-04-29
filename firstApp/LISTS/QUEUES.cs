using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.LISTS
{
    class QUEUES
    {
        public void Queue()
        {
            Queue<int> i = new Queue<int>();
            i.Enqueue(1);
            i.Enqueue(2);
            i.Enqueue(3);
            foreach(var j in i)
            {
                Console.WriteLine(j);
            }

            i.Dequeue();
            Console.WriteLine("");
            Console.WriteLine("****************** After DeQueue *******************");
            foreach(var j in i)
            {
                Console.WriteLine(j);
            }
        }
    }
}
