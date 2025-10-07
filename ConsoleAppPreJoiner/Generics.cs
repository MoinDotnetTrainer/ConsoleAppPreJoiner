using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Generics
    {
        public void Test(int x , int y)  // Datatype as an arguments
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void Test1<type1,type2>(type1 x , type2 y)  // t1 & t2 are types , not datatype
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public void Test2<T1>(T1 x) {
            Console.WriteLine(x);
        }
    }
}
