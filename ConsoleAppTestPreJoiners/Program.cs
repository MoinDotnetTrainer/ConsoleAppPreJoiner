using ClassLibrary1;
using ConsoleAppPreJoiner;
using ClassLibrary2;
namespace ConsoleAppTestPreJoiners
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //AccentureEmp obj = new AccentureEmp();
            //obj.Staff();


            //SwitchClass switchClass = new SwitchClass();
            //switchClass.Test();


            Transacations Text = new Transacations();
            Text.Deposite();
            Text.Cheques();


        }
    }
}
