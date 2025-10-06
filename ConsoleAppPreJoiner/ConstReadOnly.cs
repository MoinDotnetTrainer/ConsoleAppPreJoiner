using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class ConstReadOnly
    {
        public const int x = 89;
        public readonly int y;
        public int z;

        public ConstReadOnly()
        {
            y = 546; // we can initialize in constructor
            z = 89;
        }
        public void Test()
        {
            // x = 67;// error bcoz 
            // y = 465; // we can initialize in constructor
            z = 67;
            Console.WriteLine(x); // 546 , override
        }
    }
}
