using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_
{
    public class MethodsPractice
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a+ b);
        }

        public int Add1(int a , int b)
        {
            return a + b;
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a+b+c);
        }

        public void Test(ref int x, int y)
        {
            x = x - y;
        }

        public void Divide(
            int a,
            int b,
            out int result,
            out int remainder)
        {
            result = a / b;
            remainder = a % b;
        }


        public void DataTryParse(out int number)
        {
            bool ok = int.TryParse("10", out number);
        }
        
        public int Add2(int a, int b = 10)
        {
            int result;
            int remainder;
            Divide(a: 1, b: 2, out result, out remainder);
            return a + b;
        }

        public static void print()
        {
            Console.WriteLine("print");
        }

        public void recordPrint()
        {
            Student s = new Student(Name: "fdsfds", Age: 44);
            Student s2 = s with
            {
                Name = "fsfdsfdsfds"
            };
        }
    }
}

public record Student(string Name, int Age);