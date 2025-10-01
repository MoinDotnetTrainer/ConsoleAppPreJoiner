using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Login
    {
        public void Test() {
            string Name = "Sam";
            string pwd = "123";
            bool status = true;
            string dept = "HR";
            if (Name == "Soni" && pwd == "123")//true
            {
                if (dept == "IT")
                {
                    if (status == true)
                    {
                        Console.WriteLine("Successfully Login");
                    }
                    else
                    {
                        Console.WriteLine("Status is In Active");
                    }
                }
                else if (dept == "Sales")
                {
                    Console.WriteLine("Sales deppt");
                }
                else
                {
                    Console.WriteLine(" No dept Avail");
                }
            }
            else
            {
                Console.WriteLine(" User Name or password is not correct");
            }
        }
    }
}
