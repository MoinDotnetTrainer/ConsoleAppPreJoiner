using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class RefExample
    {
        public int print(ref int y) // x as 10 , address of y 
        {
            Console.WriteLine("y before Modification:" + y); // 10 , 10
            y = y + 10;
            Console.WriteLine("y after Modification:" + y); // 20 , 20
            return y;
        }


        public void Call()
        {
            int x = 10;
            Console.WriteLine("X in Call before:" + x); // 10 , 10
            //print(x); // call by value
            // ref i.e address of variable is passed
            print(ref x);
            Console.WriteLine("X in Call after:" + x);  // 10 , 20
        }
    }
}
