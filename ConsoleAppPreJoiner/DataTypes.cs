using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class DataTypes
    {
        public void Test()
        {
            // Integer  0-9
            // 4 categories
            // Byte --> 1 byte value = 8 bits 0-255
            // Signed +-, Unsigned +

            // Byte is Unsigned Integer   --> 0-255
            byte b = 34;
            Console.WriteLine(b);
            // sbyte is signed +-  --> -128 , 127
            sbyte x = 127;
            Console.WriteLine(x);

            // short
            short s = -32768;
            ushort us = 65000;

            //floating
            float f = 45.45f;
            double d = 45.546;
            decimal dm = 3456.4565m;

            char c = 'A';

            string str = "kjdhfksdfghfgf";

            bool b1 = false;

            // others categories of dt
            //var dynamic & object


            // compile
            var v1 = 45;
         //   v1 = "test"; // error
            v1 = 89;
            v1 = 67;

            var v2 = "Hi hello";
            v2 = "jhgj";

            var v3 = true;
            var v4 = 465.57;


            // run time
            dynamic d1 = 45;
            d1 = 345;
            d1 = true;
            d1 = 34.346;
            d1 = "test";


            dynamic d2 = "Hi hello";
            dynamic d3 = true;
            dynamic vd4 = 465.57;

            object o1 = 45;
            o1 = "test";
            object o2 = "Hi hello";
            object o3 = true;
            object o4 = 465.57;
        }
    }
}
