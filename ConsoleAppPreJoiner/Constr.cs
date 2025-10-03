using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Constr
    {
        public Constr() {  // default or implict constr
            Console.WriteLine("This is my constr without arguments");
        }
        public Constr(int x) // explict or parameterized constr 
        {
            Console.WriteLine("1 int constr");
        }
        public Constr(string x)
        {
            Console.WriteLine("1 string constr exe");
        }
    }
}
