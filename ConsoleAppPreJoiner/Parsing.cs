using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Parsing
    {
        public void Test()
        {
            string value = "123";  // as string

            int x = Convert.ToInt32(value);  // convertion 
            int x1 = int.Parse(value); // parsing

            Console.WriteLine("x val is :" + x1); // error or a value

            // test cannot be converted to  int

            byte b = byte.Parse(value); // 0-255
            sbyte sb = sbyte.Parse(value); // -128 to 127
                                           // 



        }

        public void Test1() {
            string str = null;
            int x = Convert.ToInt32(str);  // 0 , Accepts null values while converting
            int x1= int.Parse(str); // error   , no null values while parsing   
            Console.WriteLine(x1); 
        }
    }
}
