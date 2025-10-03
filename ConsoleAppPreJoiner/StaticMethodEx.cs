using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class StaticMethodEx
    {
        public static void Add() { // access class name
            int x = 45, y = 46, z;
                        z = x + y;
            Console.WriteLine("Add is :" + z);      
        }

        public static void Sub()  // access with class name
        {
            int x = 45, y = 46, z;
            z = x - y;
            Console.WriteLine("sub is :" + z);
        }

        public void mul()   // object
        {
            int x = 45, y = 46, z;
            z = x * y;
            Console.WriteLine("mul is :" + z);
        }
    }
}
