using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Properties
    {
        //int x, y, z; // default scope private 
        // y not public

        // address and a value

        // we never declare a varibales directly

        // thrw properties

        private int x;  // variable private
        public int x_ // prop public
        {
            get { return x; }
            set
            {
                if (value <= 50)
                {
                    x = value;
                }
                else
                {
                   throw new ArgumentOutOfRangeException("Value should be less than or equal to 50");
                }
            }
        }


        private int y;
        public int y_
        {
            get { return y; }
            set {
                if (value <= 50)
                {
                    y = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value should be less than or equal to 50");
                }
            }
        }

        public void Add()
        {
            int res = x + y; // <=50 <=50
            Console.WriteLine("Add is :" + res);
        }


    }
}
