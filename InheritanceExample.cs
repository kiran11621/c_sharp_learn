using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class ParentInheritanceExample
    {
        public void Show()
        {
            Console.WriteLine("fdsfdsfds");
        }
    }

    public class InheritanceExample : ParentInheritanceExample
    {
        
    }

    public class MainClass
    {
        InheritanceExample example = new InheritanceExample();

        public void main()
        {
            example.Show();
        }
    }


}
