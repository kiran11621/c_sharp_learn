using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace C2
{

    public delegate void MyDelegate(string name);

    public class DelegatesExample
    {

        public void Hello(string name)
        {
            Console.WriteLine("dsfdsfds");
        }

        public void Bye(string name)
        {
            Console.WriteLine("Byeeee");
        }
    }

    public class MainClass
    {
        DelegatesExample d = new DelegatesExample();
        
        void main()
        {
            MyDelegate del = d.Hello;
            del += d.Bye;
            del(name: "kiran");
        }
    }


    public delegate void OnComplete(string msg);

    public class DelegateComplete() { 
        public void Log(string msg)
        {
            Console.WriteLine("LOG ", msg);
        }

        public void NotifyAdmin(string msg)
        {
            Console.WriteLine("NOTIFY ", msg);
        }
    }

    public class MainDel
    {
        public void main()
        {
            OnComplete oc;
            DelegateComplete dc = new DelegateComplete();
            oc = dc.Log;
            oc += dc.NotifyAdmin;

            oc("kiran");
        }
    }

}
