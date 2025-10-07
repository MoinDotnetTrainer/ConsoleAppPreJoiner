using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    public interface IAccounts
    {
        void OpenAccount();
    }

    public class SavingAccounts_ : IAccounts
    {
        public void OpenAccount()
        {
            Console.WriteLine("Open Saving Account");
        }
    }
    public class CurrentAccounts_ : IAccounts
    {
        public void OpenAccount()
        {
            Console.WriteLine("Open Current Account");
        }
    }

    public class MyAccounts
    {
        // Insted of Creating object , we will inject
        public readonly IAccounts _account;
        public MyAccounts(IAccounts account) //sa , ca Dependency Injection
        {
            _account = account;
        }

        public void Ops() {
            _account.OpenAccount();
        }
    }

}
