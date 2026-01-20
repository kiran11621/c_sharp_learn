using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class HashSetExample
    {
        public void HashSetExamples() {
            HashSet<int> h = new HashSet<int>();

            h.Add(1);
            h.Add(2);

            h.Contains(3);
            h.Remove(3);

            h.RemoveWhere(x => x == 3);

            HashSet<int> s = new HashSet<int>();

            h.Union(s);
            foreach(int x in s)
            {
                Console.WriteLine(x);
            }

            List<int> l = new List<int> { 1, 2, 2, 2, 3, 4, 5, 6 };

            HashSet<int> hl = new HashSet<int>(l);


        }
    }
}
