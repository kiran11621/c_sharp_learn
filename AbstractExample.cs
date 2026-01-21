using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    public abstract class AbstractExample
    {
        public abstract string Name { get; set; }

        public AbstractExample(string name)
        {
            Name = name;
        }

        public abstract void Speak();

        public void JustAMethod()
        {
            Console.WriteLine("I Spoke IN A METHOD");

        }
    }

    public class Main : AbstractExample {

        public override string Name { get; set; }
        public Main(string name): base(name)
        {


        }

        public override void Speak()
        {
            Console.WriteLine("I Spoke");   
        }

        
    }

    public class AMain : Main
    {
        public AMain(string name) : base(name)
        {
        }

        public void main()
        {
            Speak();
            JustAMethod();
        }
    }


}
