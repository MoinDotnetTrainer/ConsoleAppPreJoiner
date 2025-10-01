using System;
using System.Diagnostics;
namespace ConsoleAppPreJoiner
{
    internal class Program
    {
        static void Main(string[] args) // Entry point of Program Execution
        {
            //Console.WriteLine("Hello, World!");

            //Class1 obj = new Class1();
            //obj.Test();

            //Sample obj1 = new Sample();
            //obj1.Add();

            //  DataTypes obj = new DataTypes();
            // obj.Test();

            //Readline obj = new Readline();
            // obj.Test();

            // Parsing obj = new Parsing();
            // obj.Test1();

            //   Arrays obj = new Arrays();
            //  obj.Test();

            //// int? x = null;
            // Console.WriteLine(x);
            // Console.WriteLine(x.GetValueOrDefault());

            // Condtional obj = new Condtional();
            // obj.Test();

            //   Login obj = new Login();
            //  obj.Test();

            // Switch obj = new Switch();
            // obj.Test();

            // Looping obj = new Looping();
            // obj.Test1();

            //ClassSample obj = new ClassSample();
            //obj.Add();
            //obj.Sub();
            //obj.Mul();
            //obj.Div();
            //obj.Addition();
            //obj.sub_Dynamic(y:12,x:45);// named paramerts

            //ClassSample obj1 = new ClassSample();
            //obj1.Add();

            ReturnTypeExample obj = new ReturnTypeExample();
            obj.Add();
            int res = obj.Sub();  // return
            if (res == 100)
            {
                Console.WriteLine("do this");
            }
            else
            {
                Console.WriteLine(" do that");
            }
        }
    }
}
