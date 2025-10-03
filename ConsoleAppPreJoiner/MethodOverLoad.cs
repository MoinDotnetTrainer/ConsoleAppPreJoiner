using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class MethodOverLoad
    {
        public void M1() {
            Console.WriteLine("task 1 ");
        }
        public void M1(int x) {
            Console.WriteLine("Task 2");
        }
        public void M1(double x)
        {
            Console.WriteLine("double Task 2");
        }
        public void M1(string x)
        {
            Console.WriteLine("Task 3");
        }
        public void M1(int x,int y)
        {
            Console.WriteLine("Task 4");
        }
        public void M1(int x, string y)
        {
            Console.WriteLine("Task 5");
        }
        public void M1(string x, string y)
        {
            Console.WriteLine("Task 6");
        }
    }
}
