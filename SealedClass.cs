using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    public sealed class SealedClass
    {
        public int a;
    }

    public class MainClass
    {
        void Main()
        {
            SealedClass s = new SealedClass();

            s.a = 1;
        }
    }
}

