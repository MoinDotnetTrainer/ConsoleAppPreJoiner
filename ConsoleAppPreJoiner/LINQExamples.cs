using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }
        public int Age { get; set; }
        public bool Status { get; set; }
    }
    internal class LINQExamples
    {
        public void Test()
        {
            int[] arr = { 45, 66, 67, 78, 98, 9, 45, 456, 567, 567, 586, 8678, 8979 };


            List<string> str = new List<string>() { "Test", "xyz", "Sam", "Abc", "jgffhjghj" };

            // LINQ Queries

            // Tqo ways to Write LINQ 
            // 1.Query 2.Method Syntax

            // arr is my collection

            var result = from s in arr select s; // fetch the data , filteration

            var res1 = from s in arr where s > 50 select s;// filter

            var res2 = from s in arr where s < 50 select s;

            var res3 = from s in str where s.Length >= 5 select s;

            var res4 = arr.Where(x => x > 50);

            foreach (var item in res4) // itertaing
            {
                //  Console.WriteLine(item);
            }

            // Select * from table_name where sno > 50



            List<Employees> emp = new List<Employees>() {
            new Employees{ ID=1,Name="xyz",Gender="Male" , Dept ="IT",Age=34,Status=true},
            new Employees{ ID=2,Name="Sam",Gender="FeMale" , Dept ="HR",Age=34,Status=true},
            new Employees{ ID=3,Name="Anu",Gender="FeMale" , Dept ="Sales",Age=23,Status=true},
            new Employees{ ID=4,Name="Priya",Gender="FeMale" , Dept ="IT",Age=43,Status=true},
            new Employees{ ID=5,Name="ANil",Gender="Male" , Dept ="IT",Age=34,Status=true},
            new Employees{ ID=6,Name="Pqr",Gender="Male" , Dept ="Transport",Age=34,Status=true}
            };

            var maxby = (from s in emp select s).MinBy(x => x.Age);
            // Console.WriteLine(maxby.Name);



            var empdata = from s in emp select s;
            var Deptdata = from s in emp where s.Dept == "IT" select s;
            var genres = from s in emp where s.Gender == "Male" && s.Dept == "IT" select s;

            var specific = from s in emp
                           select new
                           {
                               Name = s.Name,
                               Gen = s.Gender
                           };

            foreach (var item in specific)
            {
                //  Console.WriteLine($"ID is {item.ID} Name is :{item.Name} gender is {item.Gender} Dept is {item.Dept} Age is {item.Age} Status is {item.Status}");
                // Console.WriteLine($" Name is :{item.Name} gender is {item.Gen} ");
            }



            object[] data = { 123, 345, 4647, "Hi", "Hello", true, false, 2345.345, 546.67 };
            var intvalues = data.OfType<int>();
            var strvalues = data.OfType<string>();
            foreach (var item in strvalues)
            {
                // Console.WriteLine(item);
            }

            int[] RollNo = { 44, 56, 546, 467, 567, 5, 8678, 6, 978, 97, 989, 65, 756, 767, 86, 8789, 56, 546, 467, 567, 5, 86 };

            var unique = (from s in RollNo select s).Distinct();
            foreach (var item in unique)
            {
                //Console.WriteLine(item);
            }
            var max = (from s in RollNo select s).Max();
            //Console.WriteLine(max);

            int[] s1 = { 44, 56, 546, 467, 567, 5, 8678, 6, 978, 97, 989, 65, 756, 767, 86, 8789, 567, 5, 86, 1000 };
            int[] s2 = { 44, 56, 546, 467, 567, 5, 8678, 6, 978, 554, 65, 778, 68, 79, 467, 567, 5, 86 };

            var concat = from s in s1.Concat(s2) select s;
            foreach (var item in concat)
            {
                //Console.WriteLine(item);
            }


            var union = from s in s1.Union(s2) select s; // only uniwqe
            Console.WriteLine("Union");
            foreach (var item in union)
            {
                //  Console.WriteLine(item);
            }


            var intersect = from s in s1.Intersect(s2) select s; // Common from both the tables
            Console.WriteLine("intersect");
            foreach (var item in intersect)
            {
                //  Console.WriteLine(item);
            }

            var Except = from s in s1.Except(s2) select s; // unique from left table
            Console.WriteLine("Except");
            foreach (var item in Except)
            {
                //Console.WriteLine(item);
            }

            int[] AllEx = { 44, 56, 546, 467, 567, 5, 50, 8678, 6, 978, 97, 989, 65, 756, 767, 86, 8789, 567, 5, 86, 1000 };


            //ALl any contain return a bool value
            var all = (from s in AllEx select s).All(x => x > 50); // true or false
            var any = (from s in AllEx select s).Any(x => x > 50); // true or false
            var contains = (from s in AllEx select s).Contains(50); // true or false
            //Console.WriteLine(contains);

            List<Employees> emp1 = new List<Employees>() {
            new Employees{ ID=1,Name="xyz",Gender="Male" , Dept ="IT",Age=34,Status=true},
            new Employees{ ID=2,Name="Sam",Gender="FeMale" , Dept ="HR",Age=34,Status=true},
            new Employees{ ID=3,Name="Anu",Gender="FeMale" , Dept ="Sales",Age=23,Status=true},
            new Employees{ ID=4,Name="Priya",Gender="FeMale" , Dept ="IT",Age=43,Status=true},
            new Employees{ ID=5,Name="ANil",Gender="Male" , Dept ="IT",Age=34,Status=true},
            new Employees{ ID=6,Name="Pqr",Gender="Male" , Dept ="Transport",Age=34,Status=false}
            };

            var allex = (from s in emp1 select s).All(x => x.Gender == "Male" && x.Dept == "IT"); //  false

            var allex1 = (from s in emp1 select s).All(x => x.Status == true); //  false

            var anyex = (from s in emp1 select s).Any(x => x.Gender == "Male" && x.Dept == "IT"); // true 

            //Console.WriteLine(allex);
            //Console.WriteLine(anyex);
            // Console.WriteLine(allex1);

            int[] ElementATEx = {  556, 67, 57, 678, 79, 879, 80, 09, 46, 557, 57, 678, 78 };
            //var ele = (from s in ElementATEx select s).ElementAt(500); // index pirst(x => x > 50); // first value on cond
            //var ele5 = (from s in ElementATEx select s).FirstOrosition
            //var ele1 = (from s in ElementATEx select s).ElementAtOrDefault(400); // index position



            //var ele2 = (from s in ElementATEx select s).First(); // first value  
            //var ele3 = (from s in ElementATEx select s).Last(); // last value 


            //var ele4 = (from s in ElementATEx select s).Default(x => x < -10); // first value on cond

            // var ele6 = (from s in ElementATEx select s).Single(); // single value
            //  var ele7 = (from s in ElementATEx select s).Single(x => x == 556); // single value
            // Console.WriteLine(ele7);


            var takeex = (from s in ElementATEx select s).Take(5);
            var skip = (from s in ElementATEx select s).Skip(5);

            var tabkeby = (from s in ElementATEx select s).TakeWhile(x => x > 50); // till the cond is  t
            var skipby = (from s in ElementATEx select s).SkipWhile(x => x > 50);

            foreach (var item in skipby)
            {
                Console.WriteLine(item);
            }


        }
    }
}
