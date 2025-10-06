using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    interface x
    {
        void Land(); // they should override
    }

    interface y
    {
        void Property(); // they should override
    }

    class z
    {
        public virtual void Gold()
        {
            Console.WriteLine("This is Z class ");
        }
    }

    class z1
    {
        public virtual void Silver()
        {
            Console.WriteLine("This is Z class ");
        }
    }

    class Childrens : z, x, y  
    {
        public override void Gold()
        {
            Console.WriteLine("This is Z class ");
        }


        public void Land()
        {
            Console.WriteLine("land");
        }
        public void Property()
        {
            Console.WriteLine("Property");
        }
    }
}
