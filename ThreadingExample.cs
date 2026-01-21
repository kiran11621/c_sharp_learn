using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{

    public class Counter
    {
        public int Value = 0;
        public readonly object _lock = new object();
    }

    public class IncrementClass
    {
        public static void Main()
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine();


            int day = 3;

            switch (1)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
            public static void Increment()
        {
            Counter c = new Counter();
            for (int i = 0; i < 10; i++)
            {
                lock (c._lock)
                {
                    c.Value++;
                }
            }

            Console.WriteLine(c.Value);
        }
    }

    public class ThreadingExample
    {
        public static void Main()
        {
            Thread t = new Thread(Print);
            t.Start
                ();

            Console.WriteLine("This is main thread");
        }

        static void Print()
        {
            Console.WriteLine("Worker");
        }


    }
}
