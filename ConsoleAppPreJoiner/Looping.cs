using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Looping
    {
        public void Test()
        {
            // block of code will be executed multiple times

            // for loop
            // while
            // do while
            // for each

            // for (var ini ; condtion ; incr)
            // {
            //code
            // }

            for (int x = 10; x > 10; x++)
            {
                Console.WriteLine("x:" + x);  // till the cond is true
                //x
                //x
            }


            //while 
            int a = 10;
            while (a < 10)
            {
                Console.WriteLine("a:" + a);
                a++;
            }

            //do while
            int x1 = 10;
            do
            {
                Console.WriteLine("x1:" + x1);
                x1++;
            }
            while (x1 < 10);

            

        }

        public void Test1() {
            int[] arr = { 345, 34, 53, 654, 6, 756, 7, 8, 678, 78, 79, 789, 8, 08 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("for:" + arr[i]);
            }

            int x = 0;
            while (x < arr.Length)
            {
                Console.WriteLine("While:" + arr[x]);
                x++;
            }

            int s1 = 0;
            do
            {
                Console.WriteLine("Do :" + arr[s1]);
                s1++;
            } while (s1 < arr.Length);


            foreach (var item in arr)  // iterating 
            {
                Console.WriteLine("for each:"+item);
            }
        }
    }
}
