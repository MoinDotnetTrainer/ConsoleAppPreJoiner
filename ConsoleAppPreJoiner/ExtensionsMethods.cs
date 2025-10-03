using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    static class ExtensionsMethods
    {
        public static void Orders(this MultipleReturnTypes obj)  // exten method
        {
            Console.WriteLine(" this is orders method from another class");
        }
    }
}
