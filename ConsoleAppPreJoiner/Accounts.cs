using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    public class SavingAccounts
    {
        public void OpenAccount()
        {
            Console.WriteLine("Open Saving Account");
        }
    }

    public class CurrentAccounts
    {
        public void OpenAccount()
        {
            Console.WriteLine("Open Current Account");
        }
    }
    internal class Accounts
    {
        SavingAccounts sa = new SavingAccounts();
        CurrentAccounts ca = new CurrentAccounts();
        public void Details() {
            sa.OpenAccount();
            ca.OpenAccount();
        }
    }
}
