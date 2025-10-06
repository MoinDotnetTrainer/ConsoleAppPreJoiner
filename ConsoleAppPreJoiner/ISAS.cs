using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class ISAS
    {
        public void Test()
        {
            string x = "56";
            if (x is string)  // true else false
            {
                Console.WriteLine("X is string");
            }
            else
            {
                Console.WriteLine("X is  Number");
            }
        }

        public void Test1()
        {
            object[] arr = { "Hi", 234, "Hello", 234.45, "How ru", true };
            for (int i = 0; i < arr.Length; i++)
            {
                string myres = arr[i] as string;  // yes hi is string, return
                if (myres != null)
                {
                    Console.WriteLine(myres);
                }
                else
                {
                    Console.WriteLine("Null value");
                }
                
            }
        }
    }
}
