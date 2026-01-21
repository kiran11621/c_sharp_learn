using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal");
        } 
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Dog");
        }
    }

    public class Polymorphism
    {

        public void Main()
        {
            Dog d = new Dog();

            d.Speak();
            
        }
    }
}
