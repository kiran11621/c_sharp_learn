using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class MultiplicationTable
    {
        public void table()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("5 * " + i + " = " + 5 * i);
            }

            int j = 1;

            while (j <= 10)
            {
                Console.WriteLine("5 * " + j + " = " + 5 * j);
                j++;
            }
        }
    }
}
