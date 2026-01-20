using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class LINQExample
    {
        public void example()
        {
            List<int> n = new List<int> { 1, 2, 3, 4 };
                
            var even = n.Where(x=> x % 2 == 0);

            even.Where<int>(x=> x % 2 == 0);

            n.ForEach(e=>Console.WriteLine(e));

            var mul2 = n.Select(e=>e*2);

            foreach (var item in mul2)
            {
                Console.WriteLine(item);
            }

            var o = n.OrderBy(x=>x).ToList();


            o.ForEach(e => Console.WriteLine(-e));

            var r = from x in n where x % 2 == 0 select x;

            var ra = n.Where(x => x > 10);

            n.Add(100);   // after query

            foreach (var x in ra)
            {
                Console.WriteLine(x);
            }
        }
    }
}
