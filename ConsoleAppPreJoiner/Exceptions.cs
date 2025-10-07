using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    class Exceptions
    {
        public void Division()
        {
        a:
            try
            {
                Console.WriteLine("Enter x:");
                int x = Convert.ToInt32(Console.ReadLine());  // abc
                Console.WriteLine("Enter y:");
                int y = Convert.ToInt32(Console.ReadLine()); // true 13.3445
                int res = x / y;  // 1, 0
                Console.WriteLine("Div is :" + res);

                int[] arr = { 23};
                Console.WriteLine(arr[10]);  // index out of bound

                // int & float
                // Number or a string
                // 1 , y = 0, divide by zero error
                string str = null;
                Console.WriteLine(str.Length);
            }
           
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "Plz Enter Only Numbers");
                // not trerminating a program
                goto a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + "Plz Enter only +ve values");
                // not trerminating a program
                goto a;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "No such index found");
                // not trerminating a program
                goto a;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Plz Enter Only Numbers");
                // not trerminating a program
                goto a;
            }
        }
    }
}
