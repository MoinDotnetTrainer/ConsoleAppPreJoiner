using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate void Call1(); // no return type , no parameters , creating a delegate
public delegate int Call2(int x, int y); // return type , parameters , creating a delegate  

namespace ConsoleAppPreJoiner
{
    internal class Delegates
    {
        public void Add() // signature 
        {
            // Implementation
            Console.WriteLine("Add Logic");  
        }
        public static void Sub()
        {
            Console.WriteLine("Sub Logic");
        }

        public int Mul(int x, int y)
        {
            Console.WriteLine("Mul Logic");
            return 1;
        }
        public static int Div(int x , int y)
        {
            Console.WriteLine("Div Logic");
            return 1;
        }
    }
}
