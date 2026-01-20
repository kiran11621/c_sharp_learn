using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class DictionaryMethod
    {
        public void DictionaryMethods() { 
            Dictionary<int, string> dict =
                new Dictionary<int, string>();

            dict.Add(7, "l");

            Console.WriteLine(dict[7]);

            Dictionary<int, string> d =
                new Dictionary<int, string> {
                    {
                        1, "kiran"
                    },
                    {
                        2, "Maharana"
                    }
                };

            d.ContainsKey(2);

            d.Remove(2);

            d.TryGetValue(3, out var str);


        }
    }
}
