using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class ClassObject
    {
        StudentClass s = new StudentClass();
        StudentClass s2 = new StudentClass();
        StudentClass s3 = new StudentClass(name: "fdsfds", age: 32);

        public void method()
        {
            s.Name = "Test";
            s.Age = 23;

            s.Show();

            s2.Show();

            s3.Show();
        }
    }

    public class StudentClass
    {
        public string Name;
        public int Age;

        public StudentClass() : this("unknown", 32) { }
            

        //public StudentClass()
        //{
        //    Name = "Unknown";
        //    Age = 0;
        //}

        public StudentClass(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Show()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }
    }
}
