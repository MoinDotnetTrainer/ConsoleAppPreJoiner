using System;
using System.Diagnostics; //pre define
using ClassLibrary1;  // user define

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

            /*  MultipleReturnTypes obj = new MultipleReturnTypes();
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
            */

            /* Employee obj = new Employee();
             obj.UsersData();
             obj.ProjectData();
            */



            /* 
             Sub s = new Sub();
             s.Subtraction();
             s.Add();

             Mul m = new Mul();
             m.Multiplication();
            */

            /*   RBIBanking obj = new RBIBanking();
               obj.Withdraw();
               obj.Deposite();
               obj.StaffInfo();

               SBI s = new SBI();
               s.Withdraw();
            */


            //  Accounts acc = new Accounts();
            // acc.Details();


            /*  IAccounts ca = new CurrentAccounts_();
              MyAccounts acc = new MyAccounts(ca);
              acc.Ops();  // current data

              IAccounts sa = new SavingAccounts_();
              MyAccounts acc1 = new MyAccounts(sa);
              acc1.Ops();// saving data
          */



            //ISAS obj = new ISAS();
            //obj.Test1();



            //AccentureEmp obj = new AccentureEmp();
            //obj.Staff();
            //obj.Trainers();
            //obj.PreJoiners();
            //obj.HR();


            //Orders orders = new Orders();
            //orders.OrdersDetails(); 
            //orders.CustomerDetails();

            //RefExample obj = new RefExample();
            //obj.Call();


            //Exceptions obj= new Exceptions();
            //obj.Division();


            //try
            //{
            //    Properties obj = new Properties();
            //    obj.x_ = 3;
            //    obj.y_ = 67;
            //    obj.Add();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    Indexers ix = new Indexers();
            //    ix[0] = 45;

            //    ix[1] = 23;
            //    Console.WriteLine(ix[0]);
            //    Console.WriteLine(ix[1]);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Generics generics = new Generics();
            //generics.Test(32,35);
            //generics.Test1<int,string>(23,"Test");
            //generics.Test1<bool,bool>(true,false);

            //generics.Test2<double>(34.45);
            //generics.Test2<float>(34.45f);

            //GenericsClass<int, string> obj = new GenericsClass<int, string>();
            //obj.M1(23, "Test");
            //obj.M2(56, "Hi");



            //Collections obj = new Collections();
            //obj.NonGeneric();


            Delegates obj = new Delegates();
            //obj.Add();
            //Delegates.Sub();
            //obj.Mul(23,34);
            //Delegates.Div(3,4);


            // single cast

            Call1 c1 = new Call1(obj.Add);
            c1.Invoke();  // exposing 

            Call1 c2 = new Call1(Delegates.Sub);
            c2.Invoke();

            Call2 c3 = new Call2(obj.Mul);
            c3.Invoke(34, 34);

            Call2 c4 = new Call2(Delegates.Div);
            c4.Invoke(34, 34);

            // single cast & multi cast delegates


            // Multi cast
            Call1 x = new Call1(obj.Add);
            x += new Call1(Delegates.Sub);
            x.Invoke();


            Call2 y = new Call2(obj.Mul);
            y += new Call2(Delegates.Div);
            y.Invoke(34, 45);
        }
    }
}
