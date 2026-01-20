using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class QueueExample
    {
        Queue<int> q = new Queue<int>();
        
        public void example()
        {
            q.Enqueue(1);
            q.Enqueue(2);

            q.Dequeue();

            q.Enqueue(3);
            q.Enqueue(4);

            Console.WriteLine(q.Peek());
        }
    }
}
