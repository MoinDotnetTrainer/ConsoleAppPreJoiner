using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Switch
    {
        public void Test() {
            // in Switch as per user choice the block will be executed
            Console.WriteLine("Choose ur OPtions!!");
            Console.WriteLine("1.English , 2.Hindi , 3.Telugu");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("English");
                    break;
                case 2:
                    Console.WriteLine("Hindi");
                    break;
                case 3:
                    Console.WriteLine("Telugu");
                    break;
                default:
                    Console.WriteLine(" No Other Avail");
                    break;
            }
        }
    }
}
