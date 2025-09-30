using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Readline
    {
        public void Test()
        {

            byte b = 34;  // hardcoded or static

            // dynamic
            // readline
            Console.WriteLine(b);

            Console.WriteLine("Enter ur Name");
            string name = Console.ReadLine();  // from keyboard at runtime
            Console.WriteLine("User Name is:" + name);

            Console.WriteLine("Enter Byte value");
            byte b1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte Value is:" + b1);

            Console.WriteLine("Enter sByte value");
            sbyte sb1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sByte Value is:" + sb1);


            Console.WriteLine("Enter int value");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int Value is:" + x);

            Console.WriteLine("Enter x ");
            int x1 = Convert.ToByte(Console.ReadLine()); // does it works
            //0-255
            // > 255
            Console.WriteLine("x1 is :" + x1);
        }
    }
}
