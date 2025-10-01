using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Condtional
    {
        public void Test()
        {
            int x = 256, y = 156, z = 34;

            // condtionl statements

            //simple if , we have only if condtiona

            ///    if (//condtion) { 
            // statemnet
            //  }

            if (x < y)  // false
            {
                // executed only when the condtion is true
                Console.WriteLine("x is less  than y");
            }

            // if else

            if (x == y)//false
            {
                Console.WriteLine("x is less");
            }
            else
            {
                Console.WriteLine("y is greater");
            }

            // else if 
            if (x > y && x > z)
            {
                Console.WriteLine("x is grater");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine(" y is greater");
            }
            else
            {
                Console.WriteLine(" Z is Greater");
            }

            // nested if else

            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine(" x is greater than y & z");
                }
                else {
                    Console.WriteLine(" z is greater");
                }
            }
        }
    }
}
