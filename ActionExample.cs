using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class ActionExample
    {
        Action<int> print = msg =>
        {
            Console.WriteLine(msg);
        };

        Func<int, int, double, double, int> square = (x,y,z,a)=> x * y;

        Predicate<int> isEven = x => x % 2 == 0;

        public void Main()
        {
            print(111);
            square(1,1,1,1);
            isEven(11);
        }

    }
}
