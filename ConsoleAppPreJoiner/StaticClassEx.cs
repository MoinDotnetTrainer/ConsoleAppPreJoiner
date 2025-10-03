using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    static class StaticClassEx  // no Instance will be created
    {
        public static void Add()
        {
            Console.WriteLine("Add");
        }
        public static void sub()
        {
            Console.WriteLine("sub");
        }
        public static void mul()
        {
            Console.WriteLine("mul");
        }

        //public void div()  // obj , instance memeber
        //{
        //    Console.WriteLine("div");
        //}
    }
}
