using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Constructor
    {
        public string Name;
        public int no;

        StudentExample s = new StudentExample();

        public Constructor() 
        {
            Name = "Unknown";
            no = 0;
        }

        public void Methods()
        {
            StudentExample ss = new StudentExample(name: "fdsfds", no: 332) {
                No = no + 22323
            };

            Console.WriteLine(ss.No);
            //s.No = no;
            s.Name = Name;
        }
    }


    public class StudentExample 
    {
        public string Name { get; set; }
        public int No { get; init; }

        static StudentExample()
        {

        }

        public StudentExample()
        {
            Name = "Unknown";
            No = 0;
        }

        public StudentExample(string name, int no)
        {
            Name = name;
            No = no;
        }

        //public StudentExample(string name = "kiran", int no = 000)
        //{
        //    Name = name;
        //    No = no;
        //}

        public StudentExample(StudentExample other)
        {
            this.Name = other.Name;
            this.No = other.No;
        }
    }

}
