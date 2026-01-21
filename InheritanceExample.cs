using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class ParentInheritanceExample
    {
        public void Show()
        {
            Console.WriteLine("fdsfdsfds");
        }
    }

    public class InheritanceExample : ParentInheritanceExample
    {
        
    }

    public class MainClass
    {
        InheritanceExample example = new InheritanceExample();

        public void main()
        {
            example.Show();
        }

       
    }



    public class Animal
    {
        public string Name;

        public Animal(string name) {
            this.Name = name;
        }

        public void Eat()
        {
            Console.WriteLine(Name);
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }


}
