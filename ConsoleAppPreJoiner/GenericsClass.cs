﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class GenericsClass<t1, t2>
    {
        public void M1(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void M2(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void M3(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void M4(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void M5(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public void M6(t1 x)
        {
            Console.WriteLine(x);
        }

        public void M7(t1 x, t2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
