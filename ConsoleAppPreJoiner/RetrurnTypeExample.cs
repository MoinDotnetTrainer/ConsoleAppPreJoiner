using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    class ReturnTypeExample
    {
        public void Add()  // Ear 
        {
            int x = 45, y = 56, z;
            z = x + y;
            Console.WriteLine("Add is :" + z);  // Compiler 

        }

        public int Sub()  // Ear 
        {
            int x = 200, y = 100, z;
            z = x - y;
            Console.WriteLine("Sub is :" + z);  // Respiration 
            return z; // coz, plants
        }

        public string M1()
        {
            return "hello";
        }


        public float M2()
        {
            return 34.45f;
        }

        public double M3()
        {
            return 34.45;
        }
    }
}
