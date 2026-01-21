using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class StaticExampld
    {
        public static int count;

        static StaticExampld()
        {

        }

        public StaticExampld()
        {
            count++;
        }
    }
}
