using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoiner
{
    internal class Indexers
    {
        private int[] Age = new int[2];

        // indexers
        public int this[int index]
        {
            set
            {
                if (index >= 0 && index <= Age.Length)
                {
                    if (value > 0 && value <=50)
                    {
                        Age[index] = value;

                    }
                    else
                    {
                        Console.WriteLine("Plz Enter between 0 to 50");
                    }
                }
                else
                {
                    Console.WriteLine(" Index cannot -ve");
                }
            }
            get
            {
                return Age[index];
            }
        }

      
    }
}
