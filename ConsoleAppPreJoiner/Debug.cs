using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Debug
    {
        public void Test() {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("for loop 1st :"+i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("for loop 2nd :" + i);
            }

            int[] arr = { 45,56,56,57,67,68,78,7,9};
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public void Test1() {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());// we are taking the value from keyword
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }
    }
}
