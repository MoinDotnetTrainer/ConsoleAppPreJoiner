using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Arrays
    {
        public void Test()
        {
            //arrays 
            int x = 45;// single memory allocation for a var
            int[] arr = { 345, 546, 546, 57, 3465, 45, 345, 56, 546, 7, 56, 876, 867, 8 };
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);

            string[] str = { "Hi", "hello", "how ru" };
            Console.WriteLine(str[0]);
            Console.WriteLine(str[1]);
            Console.WriteLine(str[2]);
            //? nullable
            //[] array

            // index 0

            // array is of type reference type  , no fixed len
            int[] arr1 = new int[5] { 435, 456, 6, 45, 56 };

        }
    }
}
