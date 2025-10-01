using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class ValueTypeReftype
    {
        public void Test()
        {
            int x = 35;
            string str = "Hello";

            string str1 = null;  // ref  , it can hold null directly
            int? x1 = null; // value cannot hold null
            Nullable<int> x2 = null;

            // if i want to hold null for value type , 
            // x1 should be nulllable

            // what is Nullable

            //boxing & unboxing
            // converting a var from value type to ref type --> boxing
            // converting a var from ref type to value type --> unboxing

            int a = 123;
            string s = a.ToString();  // boxing 
            int a1 = Convert.ToInt32(s); // unboxing    
            Console.WriteLine(s); // "123"


            // Implict (auto) & Explicit (manual) Conversion
            // lower to heigher  --> Implict    
            // heigher to lower  --> Explicit   
            byte b = 23;
            int x3 = b;  // Implict
            sbyte sb = (sbyte)x3; // Explict   

            var v1 = 34;
            var v2 = "test";  // value or a ref type
        }

        public void Test1()
        {
            dynamic d1 = 34;
            dynamic d2 = 45;
            dynamic res = d1 + d2;
            Console.WriteLine(res);

            object o1 = 35;
            object o2 = 45;
            object result = (int)o1 + (int)o2;  // ref type , arthimetic
            Console.WriteLine(result);

            // abc + xyz
        }
    }
}
