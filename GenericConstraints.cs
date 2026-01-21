using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Test<T> where T : class
    {

    }

    class Test1<T> where T : struct
    {

    }

    class Test2<T> where T : new() {
        public T Create()
        {
            return new T();   // THIS line needs the constraint
        }
    }

    class GenericConstraints
    {
        Test2<int> t = new Test2<int>();

    }

    class AnimalA
    {
        CatA cat;
        DogA dog;
    }

    class CatA: AnimalA { }
    class DogA: AnimalA { }

    class Zoo<T> where T : AnimalA { }

    class OHO
    {
        void main()
        {

        Zoo<DogA> z = new Zoo<DogA> { };
        }
    }
}
