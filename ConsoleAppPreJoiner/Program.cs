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

            /* ReturnTypeExample obj = new ReturnTypeExample();
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
            */

            // Debug obj = new Debug();
            // obj.Test1();

            /*   MethodOverLoad obj = new MethodOverLoad();
               obj.M1();
               obj.M1(12.43);
               obj.M1(21);
               obj.M1("hello");
            */


            /* StaticMethodEx.Add();// one instance
             StaticMethodEx.Sub();

             StaticMethodEx.Add();  // same instance profram executes
             StaticMethodEx.Sub();

             StaticMethodEx obj = new StaticMethodEx();// obj memory allocated
             obj.mul();

             StaticMethodEx obj1 = new StaticMethodEx(); // obj1 another instance of memory 
             obj1.mul();

             StaticMethodEx obj2 = new StaticMethodEx();
             obj2.mul();
            */


            //StaticClassEx.Add();
            //StaticClassEx.sub();
            //StaticClassEx.mul();

            // Constr obj = new Constr("test");            

            MultipleReturnTypes obj = new MultipleReturnTypes();
            int x;
            string y;
            (x, y) = obj.M3();
            Console.WriteLine(x);
            Console.WriteLine(y);
            var result = obj.Calculate(4, 5);
            Console.WriteLine($"Sum: {result.sum}, Product: {result.product}");

            obj.MyCal(32, 3, out int sum1, out int Product1);
            Console.WriteLine($"Sum1: {sum1}, Product1: {Product1}");

            obj.Test(3456,456,45,7567,65,83);
            obj.Orders();
        }
    }
}
