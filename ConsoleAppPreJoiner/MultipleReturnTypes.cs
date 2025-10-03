using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    class MultipleReturnTypes
    {
        public void M1()
        {
            Console.WriteLine(" Void as a return type");
        }
        public int M2()
        {
            int x = 56, y = 45, z;
            z = x + y;
            return z;
        }
        public (int, string) M3()
        {
            if (true)
            {
                return (30, "thirty");
            }
        }
        public (int sum, int product) Calculate(int a, int b)  // tuple
        {
            return (a + b, a * b);
        }
        public void MyCal(int x, int y, out int sum, out int Product)
        {
            sum = x + y;
            Product = x * y;
        }
        //optional pm
        public void Test(int x, params int[] y)
        {
            Console.WriteLine(x);
            foreach (var item in y)  // y = no value , 1 , more than 1
            {
                Console.WriteLine("y:" + item);
            }
        }
    }
}
