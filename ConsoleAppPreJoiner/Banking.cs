using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    public abstract class Banking // Sector
    {
        public abstract void Withdraw();
        public abstract void Deposite();
        public abstract void Cheques();
    }

    public class SBH : Banking
    {
        public override void Withdraw() { }
        public override void Deposite() { }
        public override void Cheques() { }
    }
    public class YesBank : Banking
    {
        public override void Withdraw() { }
        public override void Deposite() { }
        public override void Cheques() { }
    }


}
