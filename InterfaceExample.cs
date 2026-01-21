using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public interface IAnimal
    {
        void Speak();
    }

    public class InterfaceExample : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Speak");
        }
    }

    public interface INotification
    {
        void Send(string to, string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string to, string message) { }
    }

    public class AlertService
    {
        private readonly INotification _notification;

        public AlertService(INotification notification)
        {
            _notification = notification;
        }

        public void NotifyUser()
        {
            _notification.Send("KIran", "kirna");
        }
    }

    public class MainClas
    {
        InterfaceExample a = new InterfaceExample();

        public void main()
        {
            a.Speak();
        }
    }

    interface IFly
    {
        void Fly();
    }

    interface ISwim
    {
        void Fly();
        void Info(string msg)
        {
            Console.WriteLine("Info: " + msg);
        }
    }

    class Duck : IFly, ISwim
    {

        void IFly.Fly() { }
        void ISwim.Fly() { }

        public void Info() { }
    }

    class MainDuck
    {
        void main()
        {
            Duck duck = new Duck();
            ((ISwim)duck).Fly();

            duck.Info();
        }
    }
}

