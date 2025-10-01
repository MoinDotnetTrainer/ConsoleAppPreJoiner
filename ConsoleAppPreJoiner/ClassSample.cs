using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    class ClassSample
    {
        public void Add()
        {
            int x = 45, y = 56, z;
            z = x + y;
            Console.WriteLine("Add is :" + z);
        }
        public void Addition(int x = 67, int y = 67)
        {
            int z;
            z = x + y;
            Console.WriteLine("Addition is :" + z);
        }
        public void sub_Dynamic(int x, int y )  // x = 12 or 45 
        {
            int z;
            z = x - y;
            Console.WriteLine("sub_Dynamic is :" + z);
        }

        public void Sub()
        {
            int x = 45, y = 56, z;
            z = x - y;
            Console.WriteLine("Sub is :" + z);
        }
        public void Mul()
        {
            int x = 45, y = 56, z;
            z = x * y;
            Console.WriteLine("Mul is :" + z);
        }
        public void Div()
        {
            int x = 45, y = 56, z;
            z = x / y;
            Console.WriteLine("Div is :" + z);
        }


    }
}
