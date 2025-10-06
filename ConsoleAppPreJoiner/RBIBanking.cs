using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    class RBIBanking
    {
        public virtual void Withdraw()
        {
            Console.WriteLine("This method is to implemnet WIthdraw for RBI");
        }
        public void Deposite()
        {
            Console.WriteLine("This method is to implemnet Deposite for RBI");
        }
        public void StaffInfo()
        {
            Console.WriteLine("This method is to implemnet StaffInfo for RBI");
        }
    }


    class SBI : RBIBanking
    {
        public override void Withdraw()
        {
            Console.WriteLine("This method is to implemnet WIthdraw for SBI");
        }
    }

    class Axis : RBIBanking
    {
        public override void Withdraw()
        {
            Console.WriteLine("This method is to implemnet WIthdraw for SBI");
        }
    }

    class Icici : RBIBanking
    {
        public override void Withdraw()
        {
            Console.WriteLine("This method is to implemnet WIthdraw for SBI");
        }
    }
}
