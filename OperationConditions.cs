using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class OperationConditions
    {
        public void printData()
        {
            int a = 10;
            int b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(b - a);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(b / a);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a == b);

            if (a > 10)
            {
                Console.WriteLine("a>10");
            }
            else if (a > 3)
            {
                Console.WriteLine("a<10");
            }
            else
            {
                Console.WriteLine("ok");
            }

            Console.WriteLine("Give User and Pass");
            string user = Console.ReadLine();
            string pass = Console.ReadLine();

            if(user != null && pass != null && 
                user == "admin" && pass == "1234")
            {
                Console.WriteLine("Login Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        
    }
}
