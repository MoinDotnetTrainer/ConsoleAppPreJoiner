using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Operations
    {
        protected int x, y, z;
        protected void Add()
        {
            Console.WriteLine("Enter the value of x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y:");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            Console.WriteLine("Addition is :" + z);
        }
    }

    class Sub : Operations
    {
        public void Subtraction()
        {
            Add();
            Console.WriteLine("Enter the value of x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y:");
            y = Convert.ToInt32(Console.ReadLine());
            z = x - y;
            Console.WriteLine("Subtraction is :" + z);
        }
    }

    class Mul : Operations
    {
        public void Multiplication()
        {
            Add();
            Console.WriteLine("Enter the value of x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y:");
            y = Convert.ToInt32(Console.ReadLine());
            z = x * y;
            Console.WriteLine("Multiplication is :" + z);
        }
    }
}
